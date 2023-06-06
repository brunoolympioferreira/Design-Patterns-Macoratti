﻿using Adapter1.Domain;

namespace Adapter1;
internal class SistemaMensalidades
{
    public void CalculaMensalidade(List<Aluno> listaAlunos)
    {
        foreach (Aluno aluno in listaAlunos)
        {
            //Usa uma lógica para calcular a mensalidade
            var mensalidade = aluno.Mensalidade * 1.1M;

            Console.WriteLine($"Aluno {aluno.Nome} " +
                $"- Valor da mensalidade R$ {mensalidade}");
        }
    }
}
