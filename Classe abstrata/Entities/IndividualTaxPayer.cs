namespace Classe_abstrata.Entities
{
    internal class IndividualTaxPayer : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public IndividualTaxPayer(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public sealed override double tax()
        {
            double taxHealth;
            double taxUpdate;

            if (AnualIncome <= 20000)
            {
                taxHealth = AnualIncome * 0.15;
            }
            else
            {
                taxHealth = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                taxUpdate = taxHealth - (HealthExpenditures * 0.5);
                return taxUpdate;
            }
            else
            {
                return taxHealth;
            }
        }
    }
}