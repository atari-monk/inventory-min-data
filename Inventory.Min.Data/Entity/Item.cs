using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelHelper;

namespace Inventory.Min.Data;

public class Item
    : Model
        , IModelA
{
    public int Id { get; set; }

    [Required
        , MaxLength(NameMax)]
	public string? Name { get; set; }

    [MaxLength(DescriptionMax)]
	public string? Description { get; set; }

    public int? Quantity { get; set; }

    [ForeignKey(nameof(CategoryId))]
	public int? CategoryId { get; set; }

	[Column(TypeName = Datetime2Name)]
	public DateTime? PurchaseDate { get; set; }

    [ForeignKey(nameof(CurrencyId))]
	public int? CurrencyId { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? PurchasePrice { get; set; }
	
    [Column(TypeName = "decimal(5, 2)")]
    public decimal? SellPrice { get; set; }

    [MaxLength(PathMax)]
	public string? ImagePath { get; set; }

    [ForeignKey(nameof(Unit))]
	public int? LengthUnitId { get; set; }

    public double? Length { get; set; }

	public double? Heigth { get; set; }

	public double? Depth { get; set; }

    public double?  Diameter { get; set; }

    [ForeignKey(nameof(Unit))]
	public int? VolumeUnitId { get; set; }

    public double? Volume { get; set; }

    [ForeignKey(nameof(TagId))]
	public int? TagId { get; set; }

    [ForeignKey(nameof(StateId))]
	public int? StateId { get; set; }

    [ForeignKey(nameof(Item))]
	public int? ParentId { get; set; }

    public Item? Parent { get; set; }

    public IEnumerable<Item>? Children { get; set; }

    public Category? Category { get; set; }

    public Currency? Currency { get; set; }

    public Unit? LengthUnit { get; set; }

    public Unit? VolumeUnit { get; set; }

    public Unit? Tag { get; set; }

    public Unit? State { get; set; }
}