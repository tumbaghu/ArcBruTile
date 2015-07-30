﻿using ESRI.ArcGIS.SystemUI;

namespace BrutileArcGIS.MenuDefs
{
    public class MapBoxMenuDef : IMenuDef
    {
        public string Caption
        {
            get { return "&MapBox"; }
        }
        public void GetItemInfo(int pos, IItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "AddMapBoxSatelliteLayerCommand";
                    itemDef.Group = false;
                    break;
            }
        }

        public int ItemCount
        {
            get { return 1; }
        }

        public string Name
        {
            get { return "BruTile"; }
        }
    }
}

