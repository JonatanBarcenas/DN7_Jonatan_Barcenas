using System;

namespace GymManager.Web.Models
{
    public class EquipmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public string State { get; set; }
        public int EquipmentTypeId { get; set; }
    }
}
