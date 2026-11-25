using System;
using System.Collections.Generic;

namespace ReservaSalas
{
    public class Sala
    {
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public bool Disponivel { get; set; }

        public Sala(int numero, int capacidade)
        {
            Numero = numero;
            Capacidade = capacidade;
            Disponivel = true;
        }
    }

    public class Responsavel
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }

        public Responsavel(string nome, string departamento)
        {
            Nome = nome;
            Departamento = departamento;
        }
    }

    public class Reserva
    {
        public Sala SalaReservada { get; set; }
        public Responsavel ResponsavelReserva { get; set; }
        public string Data { get; set; }
        public string Horario { get; set; }

        public Reserva(Sala sala, Responsavel responsavel, string data, string horario)
        {
            SalaReservada = sala;
            ResponsavelReserva = responsavel;
            Data = data;
            Horario = horario;
        }
    }

    public class SistemaReservas
    {
        public List<Sala> Salas { get; set; }
        public List<Responsavel> Responsaveis { get; set; }
        public List<Reserva> Reservas { get; set; }

        public SistemaReservas()
        {
            Salas = new List<Sala>();
            Responsaveis = new List<Responsavel>();
            Reservas = new List<Reserva>();
        }

        public void CadastrarSala(int numero, int capacidade)
        {
            Salas.Add(new Sala(numero, capacidade));
        }

        public void CadastrarResponsavel(string nome, string departamento)
        {
            Responsaveis.Add(new Responsavel(nome, departamento));
        }

        public void ConsultarSalasDisponiveis()
        {
            Console.WriteLine("=== Salas Disponíveis ===");
            foreach (var sala in Salas)
            {
                if (sala.Disponivel)
                {
                    Console.WriteLine($"Sala {sala.Numero} - Capacidade: {sala.Capacidade} pessoas");
                }
            }
        }

        public void RealizarReserva(int numeroSala, string nomeResponsavel, string data, string horario)
        {
            Sala salaEncontrada = null;
            foreach (var s in Salas)
            {
                if (s.Numero == numeroSala && s.Disponivel)
                {
                    salaEncontrada = s;
                    break;
                }
            }

            Responsavel respEncontrado = null;
            foreach (var r in Responsaveis)
            {
                if (r.Nome == nomeResponsavel)
                {
                    respEncontrado = r;
                    break;
                }
            }

            if (salaEncontrada != null && respEncontrado != null)
            {
                salaEncontrada.Disponivel = false;
                Reservas.Add(new Reserva(salaEncontrada, respEncontrado, data, horario));
            }
        }

        public void ConsultarReservas()
        {
            Console.WriteLine("=== Reservas Realizadas ===");
            foreach (var res in Reservas)
            {
                Console.WriteLine($"Sala {res.SalaReservada.Numero} | Responsável: {res.ResponsavelReserva.Nome} ({res.ResponsavelReserva.Departamento}) | Data: {res.Data} às {res.Horario}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            SistemaReservas sistema = new SistemaReservas();

            sistema.CadastrarSala(101, 20);
            sistema.CadastrarSala(102, 10);

            sistema.CadastrarResponsavel("Ana Paula", "TI");
            sistema.CadastrarResponsavel("Marcos Souza", "RH");

            sistema.RealizarReserva(101, "Ana Paula", "25/11/2026", "14:00");

            sistema.ConsultarSalasDisponiveis();
            Console.WriteLine();
            sistema.ConsultarReservas();
        }
    }
}
