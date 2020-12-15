﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSplit.Utilities
{
    class DatabaseUtilities
    {
        private DatabaseUtilities() { }

        private static DatabaseUtilities _databaseInstance;
        private static WeSplitEntities _databaseWeSplit;
        //private AppUtilities _appUtilities = new AppUtilities();

        public static DatabaseUtilities GetDBInstance()
        {
            if (_databaseInstance == null)
            {
                _databaseInstance = new DatabaseUtilities();
                _databaseWeSplit = new WeSplitEntities();
            }
            else
            {
                //Do Nothing
            }

            return _databaseInstance;
        }

        public List<Site> GetSiteForBindingInHomePageView(int status)
        {
            List<Site> result = new List<Site>();

            var journeysByStatus = _databaseWeSplit
                .Database
                .SqlQuery<Journey>($"Select * from Journey where Status = {status} ORDER BY ID_Journey")
                .ToList();

            foreach (var journey in journeysByStatus)
            {
                var site = _databaseWeSplit
                    .Database
                    .SqlQuery<Site>($"Select * from Site where ID_Site = {journey.ID_Site}")
                    .Single();

                site.Distance = journey.Distance ?? 0.0;
                site.ID_Journey = journey.ID_Journey;

                result.Add(site);
            }

            return result;
        } 

        public Journey GetcurrentJourney()
        {
            Journey result = _databaseWeSplit
                .Database
                .SqlQuery<Journey>("Select * from Journey where Status = 0")
                .FirstOrDefault();

            if (result != null)
            {
                var site = this.GetSiteForBindingInHomePageView(0);

                if (site.Count == 1)
                {
                    result.Site_Name = site[0].Site_Name;
                    result.Site_Avatar = site[0].Site_Link_Avt;

                    var journeyProgess = _databaseWeSplit
                        .Database
                        .SqlQuery<double>($"select [dbo].[CalcJourneyProgress]({result.ID_Journey})")
                        .Single();

                    result.Journey_Progress = journeyProgess;
                }
            }

            return result;
        }

        public List<Journey> GetListJourney()
        {
            List<Journey> result = _databaseWeSplit
                .Database
                .SqlQuery<Journey>("Select * from Journey")
                .ToList();

            if (result.Count > 0)
            {
                for (int i = 0; i < result.Count; ++i)
                {
                    Site site = _databaseWeSplit
                        .Database
                        .SqlQuery<Site>($"Select * from Site where ID_Site = {result[i].ID_Site}")
                        .FirstOrDefault();

                    result[i].Site_Name = site.Site_Name;
                    result[i].Site_Avatar = site.Site_Link_Avt;

                    result[i].Total_Day = (int)(result[i].EndDate - result[i].StartDate).Value.TotalDays;

                    result[i].Total_Day_For_Binding = $"{result[i].Total_Day} ngày";
                    result[i].Total_Distance_For_Binding = $"{result[i].Distance} km lộ trình";
                    result[i].Total_Member_For_Binding = $"{result[i].Total_Member} thành viên";

                }
            }

            return result;
        }
    }
}