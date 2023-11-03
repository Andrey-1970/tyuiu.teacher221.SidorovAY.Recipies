namespace tyuiu.teacher221.SidorovAY.Recipies.Data
{
    public class Ingridient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MesureType MesureType { get; set; }
        public Recipe Recipe { get; set; }
    }
}
