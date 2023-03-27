namespace WPFDesktop.Utils
{
    /*defined all the api routes here which needs to be call from desktop application */
    public static class ApiRoutes
  {
    public const string Root = "https://localhost:5001/api";

    public static class BroadCastMessage
    {
      public const string GetAll = Root + "/BroadCastMessages/web";

      public const string Post = Root + "/BroadCastMessages/message";
    }
  }
}
