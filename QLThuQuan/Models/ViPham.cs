namespace QLThuQuan.Models
{
    public class ViPham
    {
        public int Id { get; set; }
        public string TenViPham { get; set; }
        public string LyDo { get; set; }

        public ViPham() { }

        public ViPham(int id, string tenViPham, string lyDo)
        {
            Id = id;
            TenViPham = tenViPham;
            LyDo = lyDo;
        }
    }
}
