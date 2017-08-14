namespace vega.Models
{
    public class Make
    {
        public Make() 
        {
            
            Models =  new ICollection<Model>();
               
        }
        
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}