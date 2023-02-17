using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ICommand<T>
    {

        void Incluir(T obj);

        void Excluir(T obj);

        void Alterar(T obj);

    }   
}
