﻿using System.Collections.Generic;
using au.edu.uts.ASDF.ENETCare.InterventionManagement.Data.DataSets;
using au.edu.uts.ASDF.ENETCare.InterventionManagement.Data.DataSets.MainDataSetTableAdapters;

namespace au.edu.uts.ASDF.ENETCare.InterventionManagement.Business.DataLayerWrappers
{
    public class DistrictTableWrapper
    {
        public List<string> getDistrictsList()
        {
            List<string> districtNames = new List<string>();
            var districts = new DistrictTableAdapter().GetData();

            foreach (var district in districts)
            {
                districtNames.Add(district.Name.ToString());
            }

            return districtNames;
        }

        public string getDistrictForUser(string username)
        {
            string district = "unset";

            var districtDataTable = new DistrictTableAdapter().GetDataBy_GetDistrictByEngineerUsername(username);
            district = districtDataTable.Rows[0]["Name"].ToString();

            return district;
        }

        public List<string> getDistrictsAndIdsList()
        {
            List<string> districtNames = new List<string>();
            var districts = new DistrictTableAdapter().GetData();

            foreach (var district in districts)
            {
                districtNames.Add(district.DistrictId.ToString() + " " + district.Name.ToString());
            }

            return districtNames;
        }
    }
    
}
