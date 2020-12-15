﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeSplit
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class WeSplitEntities : DbContext
    {
        public WeSplitEntities()
            : base("name=WeSplitEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advance> Advances { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<Journey> Journeys { get; set; }
        public virtual DbSet<JourneyAttendance> JourneyAttendances { get; set; }
        public virtual DbSet<JourneyImage> JourneyImages { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
    
        [DbFunction("WeSplitEntities", "DevideMoney")]
        public virtual IQueryable<DevideMoney_Result> DevideMoney(Nullable<int> idJourney)
        {
            var idJourneyParameter = idJourney.HasValue ?
                new ObjectParameter("idJourney", idJourney) :
                new ObjectParameter("idJourney", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DevideMoney_Result>("[WeSplitEntities].[DevideMoney](@idJourney)", idJourneyParameter);
        }
    
        [DbFunction("WeSplitEntities", "GetAllFromJourney")]
        public virtual IQueryable<GetAllFromJourney_Result> GetAllFromJourney()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetAllFromJourney_Result>("[WeSplitEntities].[GetAllFromJourney]()");
        }
    
        [DbFunction("WeSplitEntities", "GetAllFromSite")]
        public virtual IQueryable<GetAllFromSite_Result> GetAllFromSite()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetAllFromSite_Result>("[WeSplitEntities].[GetAllFromSite]()");
        }
    
        [DbFunction("WeSplitEntities", "GetJourneyByStatus")]
        public virtual IQueryable<GetJourneyByStatus_Result> GetJourneyByStatus(Nullable<int> status)
        {
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetJourneyByStatus_Result>("[WeSplitEntities].[GetJourneyByStatus](@status)", statusParameter);
        }
    
        [DbFunction("WeSplitEntities", "GetLinkImageByIDJourneyAndOrdinalNumber")]
        public virtual IQueryable<GetLinkImageByIDJourneyAndOrdinalNumber_Result> GetLinkImageByIDJourneyAndOrdinalNumber(Nullable<int> idJourney, Nullable<int> ordinalNumber)
        {
            var idJourneyParameter = idJourney.HasValue ?
                new ObjectParameter("idJourney", idJourney) :
                new ObjectParameter("idJourney", typeof(int));
    
            var ordinalNumberParameter = ordinalNumber.HasValue ?
                new ObjectParameter("ordinalNumber", ordinalNumber) :
                new ObjectParameter("ordinalNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetLinkImageByIDJourneyAndOrdinalNumber_Result>("[WeSplitEntities].[GetLinkImageByIDJourneyAndOrdinalNumber](@idJourney, @ordinalNumber)", idJourneyParameter, ordinalNumberParameter);
        }
    
        [DbFunction("WeSplitEntities", "GetMemberByIDJourney")]
        public virtual IQueryable<GetMemberByIDJourney_Result> GetMemberByIDJourney(Nullable<int> idJourney)
        {
            var idJourneyParameter = idJourney.HasValue ?
                new ObjectParameter("idJourney", idJourney) :
                new ObjectParameter("idJourney", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetMemberByIDJourney_Result>("[WeSplitEntities].[GetMemberByIDJourney](@idJourney)", idJourneyParameter);
        }
    
        [DbFunction("WeSplitEntities", "GetRouteByIDJourney")]
        public virtual IQueryable<GetRouteByIDJourney_Result> GetRouteByIDJourney(Nullable<int> idJourney)
        {
            var idJourneyParameter = idJourney.HasValue ?
                new ObjectParameter("idJourney", idJourney) :
                new ObjectParameter("idJourney", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetRouteByIDJourney_Result>("[WeSplitEntities].[GetRouteByIDJourney](@idJourney)", idJourneyParameter);
        }
    
        [DbFunction("WeSplitEntities", "Result")]
        public virtual IQueryable<Result_Result> Result(Nullable<int> idJourney)
        {
            var idJourneyParameter = idJourney.HasValue ?
                new ObjectParameter("idJourney", idJourney) :
                new ObjectParameter("idJourney", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Result_Result>("[WeSplitEntities].[Result](@idJourney)", idJourneyParameter);
        }
    
        [DbFunction("WeSplitEntities", "SearchByJourneyName")]
        public virtual IQueryable<SearchByJourneyName_Result> SearchByJourneyName(string search_text)
        {
            var search_textParameter = search_text != null ?
                new ObjectParameter("search_text", search_text) :
                new ObjectParameter("search_text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SearchByJourneyName_Result>("[WeSplitEntities].[SearchByJourneyName](@search_text)", search_textParameter);
        }
    
        [DbFunction("WeSplitEntities", "SearchByJourneySiteName")]
        public virtual IQueryable<SearchByJourneySiteName_Result> SearchByJourneySiteName(string search_text)
        {
            var search_textParameter = search_text != null ?
                new ObjectParameter("search_text", search_text) :
                new ObjectParameter("search_text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SearchByJourneySiteName_Result>("[WeSplitEntities].[SearchByJourneySiteName](@search_text)", search_textParameter);
        }
    
        [DbFunction("WeSplitEntities", "SearchByMemberName")]
        public virtual IQueryable<SearchByMemberName_Result> SearchByMemberName(string search_text)
        {
            var search_textParameter = search_text != null ?
                new ObjectParameter("search_text", search_text) :
                new ObjectParameter("search_text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SearchByMemberName_Result>("[WeSplitEntities].[SearchByMemberName](@search_text)", search_textParameter);
        }
    
        [DbFunction("WeSplitEntities", "SearchByProvinceName")]
        public virtual IQueryable<SearchByProvinceName_Result> SearchByProvinceName(string search_text)
        {
            var search_textParameter = search_text != null ?
                new ObjectParameter("search_text", search_text) :
                new ObjectParameter("search_text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SearchByProvinceName_Result>("[WeSplitEntities].[SearchByProvinceName](@search_text)", search_textParameter);
        }
    
        [DbFunction("WeSplitEntities", "SearchJourney")]
        public virtual IQueryable<SearchJourney_Result> SearchJourney(string search_text)
        {
            var search_textParameter = search_text != null ?
                new ObjectParameter("search_text", search_text) :
                new ObjectParameter("search_text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SearchJourney_Result>("[WeSplitEntities].[SearchJourney](@search_text)", search_textParameter);
        }
    
        public virtual int AddExpense(Nullable<int> idExpenses, Nullable<int> idJourney, Nullable<decimal> expense, string des)
        {
            var idExpensesParameter = idExpenses.HasValue ?
                new ObjectParameter("idExpenses", idExpenses) :
                new ObjectParameter("idExpenses", typeof(int));
    
            var idJourneyParameter = idJourney.HasValue ?
                new ObjectParameter("idJourney", idJourney) :
                new ObjectParameter("idJourney", typeof(int));
    
            var expenseParameter = expense.HasValue ?
                new ObjectParameter("expense", expense) :
                new ObjectParameter("expense", typeof(decimal));
    
            var desParameter = des != null ?
                new ObjectParameter("des", des) :
                new ObjectParameter("des", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddExpense", idExpensesParameter, idJourneyParameter, expenseParameter, desParameter);
        }
    
        public virtual int AddJourney(Nullable<int> idSite, string startPlace, string startProvince, Nullable<int> status, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<double> distance)
        {
            var idSiteParameter = idSite.HasValue ?
                new ObjectParameter("idSite", idSite) :
                new ObjectParameter("idSite", typeof(int));
    
            var startPlaceParameter = startPlace != null ?
                new ObjectParameter("startPlace", startPlace) :
                new ObjectParameter("startPlace", typeof(string));
    
            var startProvinceParameter = startProvince != null ?
                new ObjectParameter("startProvince", startProvince) :
                new ObjectParameter("startProvince", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddJourney", idSiteParameter, startPlaceParameter, startProvinceParameter, statusParameter, startDateParameter, endDateParameter, distanceParameter);
        }
    
        public virtual int AddJourneyAttendance(Nullable<int> idMember, Nullable<int> idJourney, Nullable<decimal> receivable, string role)
        {
            var idMemberParameter = idMember.HasValue ?
                new ObjectParameter("idMember", idMember) :
                new ObjectParameter("idMember", typeof(int));
    
            var idJourneyParameter = idJourney.HasValue ?
                new ObjectParameter("idJourney", idJourney) :
                new ObjectParameter("idJourney", typeof(int));
    
            var receivableParameter = receivable.HasValue ?
                new ObjectParameter("Receivable", receivable) :
                new ObjectParameter("Receivable", typeof(decimal));
    
            var roleParameter = role != null ?
                new ObjectParameter("role", role) :
                new ObjectParameter("role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddJourneyAttendance", idMemberParameter, idJourneyParameter, receivableParameter, roleParameter);
        }
    
        public virtual int AddJourneyImages(Nullable<int> idJourney, Nullable<int> oridnalNum, string linkImage)
        {
            var idJourneyParameter = idJourney.HasValue ?
                new ObjectParameter("idJourney", idJourney) :
                new ObjectParameter("idJourney", typeof(int));
    
            var oridnalNumParameter = oridnalNum.HasValue ?
                new ObjectParameter("oridnalNum", oridnalNum) :
                new ObjectParameter("oridnalNum", typeof(int));
    
            var linkImageParameter = linkImage != null ?
                new ObjectParameter("linkImage", linkImage) :
                new ObjectParameter("linkImage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddJourneyImages", idJourneyParameter, oridnalNumParameter, linkImageParameter);
        }
    
        public virtual int AddMember(string memberName, string phoneNumber, string memberLinkAvt)
        {
            var memberNameParameter = memberName != null ?
                new ObjectParameter("memberName", memberName) :
                new ObjectParameter("memberName", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("phoneNumber", phoneNumber) :
                new ObjectParameter("phoneNumber", typeof(string));
    
            var memberLinkAvtParameter = memberLinkAvt != null ?
                new ObjectParameter("memberLinkAvt", memberLinkAvt) :
                new ObjectParameter("memberLinkAvt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddMember", memberNameParameter, phoneNumberParameter, memberLinkAvtParameter);
        }
    
        public virtual int AddRoute(Nullable<int> idJourney, Nullable<int> ordinalNumber, string place, string province, string routeDescription, Nullable<int> routeStatus)
        {
            var idJourneyParameter = idJourney.HasValue ?
                new ObjectParameter("idJourney", idJourney) :
                new ObjectParameter("idJourney", typeof(int));
    
            var ordinalNumberParameter = ordinalNumber.HasValue ?
                new ObjectParameter("ordinalNumber", ordinalNumber) :
                new ObjectParameter("ordinalNumber", typeof(int));
    
            var placeParameter = place != null ?
                new ObjectParameter("place", place) :
                new ObjectParameter("place", typeof(string));
    
            var provinceParameter = province != null ?
                new ObjectParameter("province", province) :
                new ObjectParameter("province", typeof(string));
    
            var routeDescriptionParameter = routeDescription != null ?
                new ObjectParameter("routeDescription", routeDescription) :
                new ObjectParameter("routeDescription", typeof(string));
    
            var routeStatusParameter = routeStatus.HasValue ?
                new ObjectParameter("routeStatus", routeStatus) :
                new ObjectParameter("routeStatus", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddRoute", idJourneyParameter, ordinalNumberParameter, placeParameter, provinceParameter, routeDescriptionParameter, routeStatusParameter);
        }
    
        public virtual int AddSite(Nullable<int> idProvince, string siteName, string siteDescription, string siteLinkAvt, string siteAddress)
        {
            var idProvinceParameter = idProvince.HasValue ?
                new ObjectParameter("idProvince", idProvince) :
                new ObjectParameter("idProvince", typeof(int));
    
            var siteNameParameter = siteName != null ?
                new ObjectParameter("siteName", siteName) :
                new ObjectParameter("siteName", typeof(string));
    
            var siteDescriptionParameter = siteDescription != null ?
                new ObjectParameter("siteDescription", siteDescription) :
                new ObjectParameter("siteDescription", typeof(string));
    
            var siteLinkAvtParameter = siteLinkAvt != null ?
                new ObjectParameter("siteLinkAvt", siteLinkAvt) :
                new ObjectParameter("siteLinkAvt", typeof(string));
    
            var siteAddressParameter = siteAddress != null ?
                new ObjectParameter("siteAddress", siteAddress) :
                new ObjectParameter("siteAddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddSite", idProvinceParameter, siteNameParameter, siteDescriptionParameter, siteLinkAvtParameter, siteAddressParameter);
        }
    }
}