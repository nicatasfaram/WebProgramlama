namespace WebProgramlama.Models
{
    public class Project
    {
        public string Name { get; set; }
        public ICollection<Component>? Components { get; set; }
        public DateTime CreateTime { get; set; }
        

    }
}
