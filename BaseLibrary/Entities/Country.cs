
namespace BaseLibrary.Entities
{
    public class Country : BaseEntity
    {
        // One to Many relationship with City
        public List<City>? Cities { get; set; }
    }
}
