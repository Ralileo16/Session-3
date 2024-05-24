namespace ExamW24.Models
{
    internal class s3p
    {
        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
		public virtual string? User { get; set; }

		public virtual AspNetUser? FKUser { get; set; }
		public List<Product>? ThreeProds { get; set; }
    }
}