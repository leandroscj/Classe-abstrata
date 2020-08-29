namespace Classe_abstrata.Entities
{
    internal class CompanyTaxPayer : TaxPayer
    {
        public int NumberOfEmployes { get; set; }

        public CompanyTaxPayer(string name, double anualIncome, int numberOfEmployes) : base(name, anualIncome)
        {
            NumberOfEmployes = numberOfEmployes;
        }

        public sealed override double tax()
        {
            if (NumberOfEmployes >= 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}