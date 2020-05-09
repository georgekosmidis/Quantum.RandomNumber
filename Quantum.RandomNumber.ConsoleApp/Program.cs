using System;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.RandomNumber.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ExecuteQuantumRandom().GetAwaiter().GetResult();
            Console.Write("The atom number {0} has been selected", result);
        }

        private static async Task<BigInteger> ExecuteQuantumRandom()
        {
            using var sim = new QuantumSimulator();
            var atomsInTheUniverse = BigInteger.Pow(10, 80);
            return await Quantum.RandomNumber.Generate.Run(sim, atomsInTheUniverse);
        }
    }
}
