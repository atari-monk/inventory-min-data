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
    }
}