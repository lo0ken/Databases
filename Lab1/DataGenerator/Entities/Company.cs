
namespace Generator_v._2.Entities
{
    public class Company
    {
        public int Id { get; private set; }
        public string CompanyName { get; private set; }

        public Company(int id, string companyName)
        {
            Id = id;
            CompanyName = companyName;
        }

        public override string ToString()
        {
            return Id.ToString() + Program.fieldTerminator + CompanyName;
        }
    }
}
