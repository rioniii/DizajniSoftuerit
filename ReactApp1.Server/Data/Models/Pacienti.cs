﻿namespace ReactApp1.Server.Data.Models
{
    public class Pacienti
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public string Historiku { get; set; }
        public DateTime Ditelindja { get; set; }

        public List<Termini> Terminet { get; set; }
        public List<Historiku> Historiks { get; set; }
        public List<Fatura> Faturat { get; set; }
        public List<DhomaPacientit> DhomaPacienteve { get; set; }

    }
}
