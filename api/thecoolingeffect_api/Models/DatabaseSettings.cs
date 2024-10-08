﻿namespace thecoolingeffect_api.Models
{
  /// <summary>
  /// Database settings
  /// </summary>
  public class DatabaseSettings
  {
    /// <summary>
    /// Gets or sets the connection string
    /// </summary>
    public string ConnectionString { get; set; } = "";

    /// <summary>
    /// Gets or sets the database name
    /// </summary>
    public string DatabaseName { get; set; } = "";
  }
}
