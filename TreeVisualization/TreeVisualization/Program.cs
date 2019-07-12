using System;
using ApplicationCore.Interfaces;
using Autofac;
using Infrastructure.ObjectMapping;

namespace TreeVisualization
{
    public class Program
    {
        [STAThread]
        private static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ObjectMapFactory>().As<IObjectMapFactory>().SingleInstance();

            App.Main();
        }
    }
}