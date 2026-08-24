namespace AMS.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int AccessionId { get; set; }
        public string InventoryType { get; set; } = string.Empty;
        public string MaintenancePolicy { get; set; } = string.Empty;
        public string AvailabilityStatus { get; set; } = string.Empty;
        public string IsDistributable { get; set; } = string.Empty;// 'Yes' || 'No' || 'Limited/IPR'
        public string LocationSelection1 { get; set; } = string.Empty;
        public string LocationSelection2 { get; set; } = string.Empty;
        public string LocationSelection3 { get; set; } = string.Empty;
        public string LocationSelection4 { get; set; } = string.Empty;
    }
}
