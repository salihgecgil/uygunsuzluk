using System.ComponentModel.DataAnnotations;
using UygunsuzlukRaporuProjesi.Enums;

namespace UygunsuzlukRaporuProjesi.Models
{
    public class Unsuitability
    {
        [Key]
        public int UnsuitabilityNumber { get; set; }
        [Required]
        public UnsuitabilityType UnsuitabilityType { get; set; }
        [MaxLength(200)]
        [Required]
        public string OrderNumber { get; set; }
        [MaxLength(200)]
        [Required]
        public string ProjectNumber { get; set; }
        [MaxLength(200)]
        public string WorkOrderNumber { get; set; }
        [MaxLength(200)]
        public string PartNumber { get; set; }
        public DateTime UnsuitabilityData { get; set; }
        [MaxLength(200)]
        public string PartRevisionNumber { get; set; }
        [MaxLength(200)]
        public string UnsuitabilityDetectedCenterNumber { get; set; }
        [MaxLength(200)]
        public string UnsuitabilityDetectedOperationNumber { get; set; }
        public int ProductionQuantity { get; set; }
        public int AcceptedQuantity { get; set; }
        public int UnsuitabilityQuantity { get; set; }
        [MaxLength(200)]
        public string UnsuitabilePersonel { get; set; }
        [MaxLength(200)]
        public string UnsuitabileSection { get; set; }
        [MaxLength(200)]
        public string SerialNumber { get; set; }
        [MaxLength(200)]
        public string CustomerInfo { get; set; }
        [MaxLength(200)]
        public string UnsuitabilityDefinition { get; set; }
        [MaxLength(200)]
        public string UnsuitabilityIdentifierInfo { get; set; }
        public DateTime UnsuitabilityIdentifiingDate { get; set; }
        [MaxLength(200)]
        public string UnsuitabilityConfirmerInfo { get; set; }
        public DateTime UnsuitabilityConfirmingInfo { get; set; }
        [MaxLength(5000)]
        public string? EmergencySolution { get; set; }
        [MaxLength(200)]
        public string? EmergencySolutionWriterInfo { get; set; }
        public DateTime? EmergencySolutionDate { get; set; }
        [MaxLength(200)]
        public string UnsuitabilityCodeAndDescription { get; set; }
        public bool IsCustomerProduct { get; set; }
        public bool IsDfActivityRequired { get; set; }
        [MaxLength(5000)]
        public string ActionForRefusingUnsuitability { get; set; }
        [MaxLength(200)]
        public string ActionForRefusingUnsuitabilityPersonelInfo { get; set; }
        public DateTime ActionForRefusingUnsuitabilityDate{ get; set; }
        [MaxLength(5000)]
        public string AuditResult{ get; set; }
        [MaxLength(200)]
        public string UnsuitabilityDetectorPersonelInfo{ get; set; }
        public DateTime UnsuitabilityDetectionDate{ get; set; }

    }
}
