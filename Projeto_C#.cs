using System;

namespace ProjetoCarroJoão
{
    // ==========================================
    // 5. ABSTRAÇÃO (Interface que define o comportamento genérico)
    // ==========================================
    public interface IVeiculo
    {
        void Mover();
    }

    // ==========================================
    // 1. CLASSE E 4. ENCAPSULAMENTO
    // A classe principal "CarroJoao" que serve de modelo.
    // O encapsulamento esconde detalhes internos complexos.
    // ==========================================
    public class CarroJoao : IVeiculo
    {
        public string Modelo { get; set; }
        public int Rodas { get; private set; }
        private bool MotorLigado { get; set; }

        public CarroJoao(string modelo)
        {
            Modelo = modelo;
            Rodas = 4;
            MotorLigado = false;
        }

        public virtual void Mover()
        {
            Console.WriteLine($"{Modelo} está a andar na estrada de forma padrão.");
        }

        public void LigarMotor()
        {
            MotorLigado = true;
            Console.WriteLine($"[Sistema interno] O motor do {Modelo} foi ligado de forma simples para o motorista.");
        }
    }

    // ==========================================
    // 3. HERANÇA (Variantes do CarroJoão original)
    // ==========================================
    public class CarroJoaoSports : CarroJoao
    {
        public CarroJoaoSports(string modelo) : base(modelo) { }

        public override void Mover()
        {
            Console.WriteLine($"{Modelo} acelera rapidamente com um design esportivo e motor potente!");
        }
    }

    public class CarroJoaoSUV : CarroJoao
    {
        public CarroJoaoSUV(string modelo) : base(modelo) { }

        public override void Mover()
        {
            Console.WriteLine($"{Modelo} desbrava terrenos difíceis com maior altura e capacidade de carga.");
        }
    }

    public class CarroJoaoEco : CarroJoao
    {
        public CarroJoaoEco(string modelo) : base(modelo) { }

        public override void Mover()
        {
            Console.WriteLine($"{Modelo} move-se de forma elétrica, silenciosa e com incrível economia de combustível!");
        }
    }

    // ==========================================
    // Outros veículos para demonstrar o Polimorfismo
    // ==========================================
    public class OnibusJoao : IVeiculo
    {
        public void Mover()
        {
            Console.WriteLine("ÔnibusJoão transporta passageiros pelas ruas da cidade.");
        }
    }

    public class CaminhaoJoao : IVeiculo
    {
        public void Mover()
        {
            Console.WriteLine("CaminhãoJoão transporta cargas pesadas pelas rodovias.");
        }
    }

    public class MotoJoao : IVeiculo
    {
        public void Mover()
        {
            Console.WriteLine("MotoJoão ziguezagueia agilmente pelo trânsito.");
        }
    }

    // ==========================================
    // PROGRAMA PRINCIPAL
    // ==========================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== A JORNADA DE JOÃO ATRAVÉS DOS PRINCÍPIOS DA POO ===\n");

            // 2. OBJETO (Instanciação da classe CarroJoao)
            CarroJoao meuCarroFisico = new CarroJoao("CarroJoão Base");
            meuCarroFisico.LigarMotor(); // Encapsulamento
            meuCarroFisico.Mover();

            Console.WriteLine("\n--- Herança e Polimorfismo com Variantes ---");

            // Array de veículos demonstrando Polimorfismo (sem usar Generic.Collections)
            IVeiculo[] frotaDoJoao = new IVeiculo[]
            {
                new CarroJoaoSports("CarroJoãoSports"),
                new CarroJoaoSUV("CarroJoãoSUV"),
                new CarroJoaoEco("CarroJoãoEco"),
                new OnibusJoao(),
                new CaminhaoJoao(),
                new MotoJoao()
            };

            // Todos são tratados como veículos, mas cada um se move de forma específica (Polimorfismo)
            foreach (var veiculo in frotaDoJoao)
            {
                veiculo.Mover();
            }

            Console.WriteLine("\nFim da demonstração da jornada de João!");
        }
    }
}
