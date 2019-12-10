using UnityEngine;
using UnityEngine.UI;

namespace FoW
{
    [RequireComponent(typeof(RawImage))]
    public class FogOfWarMinimap : MonoBehaviour
    {
        public int team = 0;
        public Color fogColor = Color.black;
        public Color nonFogColor = Color.white;
        public Color unitColor = Color.blue;
        public Color enemyColor = Color.red;
        public Color cameraColor = Color.green;
        [Range(0, 1)]
        public float opponentMinFogStrength = 0.2f;
        public new Camera camera;
        public int iconSize = 2;
        public AspectRatioFitter aspectRatioFitter;

        Texture2D _texture;
        byte[] _fogValues;
        Color[] _pixels;

        void OnDestroy()
        {
            Destroy(_texture);
        }

        void LateUpdate()
        {
            FogOfWarTeam fow = FogOfWarTeam.GetTeam(team);
            if (fow == null)
                return;

            // setup texture
            if (_texture == null || _texture.width != fow.mapResolution.x || _texture.height != fow.mapResolution.y)
            {
                if (_texture != null)
                    Destroy(_texture);

                _texture = new Texture2D(fow.mapResolution.x, fow.mapResolution.y, TextureFormat.ARGB32, false, false);
                _texture.name = "FogOfWarMinimap";
                _fogValues = new byte[fow.mapResolution.x * fow.mapResolution.y];
                _pixels = new Color[fow.mapResolution.x * fow.mapResolution.y];

                GetComponent<RawImage>().texture = _texture;
                if (aspectRatioFitter != null)
                    aspectRatioFitter.aspectRatio = (float)fow.mapResolution.x / fow.mapResolution.y;
            }

            // fog
            fow.GetTotalFogValues(ref _fogValues);
            for (int i = 0; i < _fogValues.Length; ++i)
                _pixels[i] = Color.LerpUnclamped(nonFogColor, fogColor, _fogValues[i] / 255.0f);

            // units
            byte opponentminvisibility = (byte)(opponentMinFogStrength * 255);
            for (int i = 0; i < FogOfWarUnit.registeredUnits.Count; ++i)
            {
                FogOfWarUnit unit = FogOfWarUnit.registeredUnits[i];
                if (unit.team == team)
                    DrawIconOnMap(fow, unit.transform.position, unitColor);
                else
                    DrawIconOnMap(fow, unit.transform.position, enemyColor, opponentminvisibility);
            }

            // camera
            if (camera != null)
                DrawIconOnMap(fow, camera.transform.position, cameraColor);

            // apply to texture
            _texture.SetPixels(_pixels);
            _texture.Apply(false, false);
        }

        void DrawIconOnMap(FogOfWarTeam fow, Vector3 worldpos, Color color, byte maxfogamount = 255)
        {
            Vector2Int fogpos = fow.WorldPositionToFogPosition(worldpos);
            if (fogpos.x < 0 || fogpos.x >= fow.mapResolution.x ||
                fogpos.y < 0 || fogpos.y >= fow.mapResolution.y)
                return;

            if (maxfogamount < 255 && _fogValues[fow.mapResolution.y * fogpos.y + fogpos.x] > maxfogamount)
                return;

            int offset = (iconSize / 2) - 1;
            int xmin = fogpos.x - offset;
            int xmax = fogpos.x + offset;
            int ymin = fogpos.y - offset;
            int ymax = fogpos.y + offset;
            for (int y = ymin; y <= ymax; ++y)
            {
                if (y < 0 || y >= fow.mapResolution.y)
                    continue;

                for (int x = xmin; x <= xmax; ++x)
                {
                    if (x < 0 || x >= fow.mapResolution.x)
                        continue;
                    
                    _pixels[fow.mapResolution.y * y + x] = color;
                }
            }
        }
    }
}
