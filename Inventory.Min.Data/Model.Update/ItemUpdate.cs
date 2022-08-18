using ModelHelper;

namespace Inventory.Min.Data;

public class ItemUpdate 
    : ModelAUpdate 
    , IUpdatable<Item>
{
    public int? CategoryId { get; set; }
    public int? CurrencyId { get; set; }
    public int? LengthUnitId { get; set; }
    public int? VolumeUnitId { get; set; }
    public int? TagId { get; set; }
    public int? StateId { get; set; }
    public int? ParentId { get; set; }
    public double? Mass { get; set; }
    public int? MassUnitId { get; set; }
	public int? Quantity { get; set; }
	public DateTime? PurchaseDate { get; set; }
    
    public void Update(Item model)
    {
        base.Update(model);
        
        if (CategoryId.HasValue
            && CategoryId.Value != model.CategoryId)
            model.CategoryId = CategoryId.Value;

        if (CurrencyId.HasValue
            && CurrencyId.Value != model.CurrencyId)
            model.CurrencyId = CurrencyId.Value;

        if (LengthUnitId.HasValue
            && LengthUnitId.Value != model.LengthUnitId)
            model.LengthUnitId = LengthUnitId.Value;

        if (VolumeUnitId.HasValue
            && VolumeUnitId.Value != model.VolumeUnitId)
            model.VolumeUnitId = VolumeUnitId.Value;
        
        if (TagId.HasValue
            && TagId.Value != model.TagId)
            model.TagId = TagId.Value;

        if (StateId.HasValue
            && StateId.Value != model.StateId)
            model.StateId = StateId.Value;

        if (ParentId.HasValue
            && ParentId.Value != model.ParentId)
            model.ParentId = ParentId.Value;
        
         if (Mass.HasValue
            && Mass.Value != model.Mass)
            model.Mass = Mass.Value;

         if (MassUnitId.HasValue
            && MassUnitId.Value != model.MassUnitId)
            model.MassUnitId = MassUnitId.Value;
		
			if (Quantity.HasValue
            && Quantity.Value != model.Quantity)
            model.Quantity = Quantity.Value;
			
			if (PurchaseDate.HasValue
            && PurchaseDate.Value != model.PurchaseDate)
            model.PurchaseDate = PurchaseDate.Value;
			
    }
}