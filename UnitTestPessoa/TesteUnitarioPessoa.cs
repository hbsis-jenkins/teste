using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PessoaDTO;

namespace UnitTestePessoa
{
    [TestClass]
    public class TesteUnitarioPessoa
    {
        [TestMethod]
        public void Validar_Criacao_De_Uma_Instancia_De_Pessoa()
        {
            String strCPF = "11111111111", strNome = "Lorem Ipsum";

            Pessoa clsPessoa = new Pessoa(strCPF, strNome);

            Assert.IsNotNull(clsPessoa);
            Assert.IsTrue(clsPessoa.Cpf.Equals(strCPF));
            Assert.IsTrue(clsPessoa.Nome.Equals(strNome));
        }
    }
}
