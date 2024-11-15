using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental.Domain;

/// <summary>
/// Class Bike has the info about bikes
/// </summary>
[Table("bike")]
public class Bike
{
    /// <summary>
    /// Id of a bike
    /// </summary>
    [Column("id")]
    public int Id { get; set; }

    /// <summary>
    /// Serial number of a bike
    /// </summary>
    [Column("serial_number")]
    public int SerialNumber { get; set; }

    /// <summary>
    /// Model info of a bike
    /// </summary>
    [Column("model")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Color info of a bike
    /// </summary>
    [Column("color")]
    public string Color { get; set; } = string.Empty;

    /// <summary>
    /// Id of a bike type
    /// </summary>
    [Column("type_id")]
    public int TypeId { get; set; }

    /// <summary>
    /// Type of a rented bike
    /// </summary>
    public BikeType? Type { get; set; }
}
