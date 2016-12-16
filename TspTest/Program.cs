﻿using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TspTest.Genetic;

namespace TspTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string[] lines = File.ReadAllLines(@"D:/distances.txt");
            //int n = Convert.ToInt32(lines[0]), index = 1;
            //var distances = Matrix<double>.Build.Dense(n, n, 0);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if(i != j)
            //        { 
            //            distances[i, j] = Convert.ToDouble(lines[index++]);
            //        }
            //    }
            //}
            //Console.WriteLine();
            ////IList<int> result = new Hopfield(n, distances).Solve();
            //var result = new SimulatedAnnealing.SimulatedAnnealing(distances).Solve();
            //Console.WriteLine($"Path = {result.Item1.Select(x => x.ToString()).Aggregate((x, y) => x + " " + y)}\nCost = {result.Item2}");
            //Console.ReadLine();

            //cityLocations(1,:) = [0 3];
            //cityLocations(2,:) = [1 5];
            //cityLocations(3,:) = [4 5];
            //cityLocations(4,:) = [5 2];
            //cityLocations(5,:) = [4 0];
            //cityLocations(6,:) = [1 0];
            IList<City> l = new List<City>();
            //l.Add(new City { Name = "city1", Position = new PointF(0, 3) });
            //l.Add(new City { Name = "city2", Position = new PointF(1, 5) });
            //l.Add(new City { Name = "city3", Position = new PointF(4, 5) });
            //l.Add(new City { Name = "city4", Position = new PointF(5, 2) });
            //l.Add(new City { Name = "city5", Position = new PointF(4, 0) });
            //l.Add(new City { Name = "city6", Position = new PointF(1, 0) });

            l.Add(new City { Name = "city2", Position = new PointF(0, 0) });
            l.Add(new City { Name = "city3", Position = new PointF(35, 0) });
            l.Add(new City { Name = "city1", Position = new PointF(8, 6) });
            l.Add(new City { Name = "city4", Position = new PointF(5, 5) });

            //TSP prob = new TSP(l);
            //prob.Solve();
            Genetic.Path path = new GeneticAlgorithm(new Population(l, 10)).Solve();
            Console.WriteLine(path);
            Console.ReadKey();
        }
    }
}
