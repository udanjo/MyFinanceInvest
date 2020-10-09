namespace MyFinanceInvest.Response
{
    public class BankResponse
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string DescriptionComplete {
            get { return Code + "-" + Description; } 
        }
    }
}