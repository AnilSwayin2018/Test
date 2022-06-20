namespace TestApp;
public static class ApiRoutes
{
    private const string ApiBase = "/api";

    private static class Library
    {
        private const string Base = ApiBase + "/library";
        public const string getyId = $"{Base}/{{id:guid}}";
        public const string GetAll = Base;
       
    }
}