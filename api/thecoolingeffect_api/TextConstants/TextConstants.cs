namespace thecoolingeffect_api.TextConstants
{
  /// <summary>
  /// Text Constants Class
  /// </summary>
  public static class TextConstants
  {
    /// <summary>
    /// Errors Text Constants
    /// </summary>
    public static class Errors
    {
      public const string FailedToFetchAboutDetails = "Failed to get about details from the database.";
      public const string AboutDetailsNotFound = "Could not find the about details data from the database.";
      public const string InvalidDatabaseSettings = "Invalid database settings.";
    }

    /// <summary>
    /// Information Text Constants
    /// </summary>
    public static class Information
    {
      public const string FetchingAboutDetails = "Fetching about details from database.";
    }

    /// <summary>
    /// Database Information Text Constants
    /// </summary>
    public static class DatabaseInformation
    {
      public const string CollectioName = "AboutDetails";
    }
  }
}
