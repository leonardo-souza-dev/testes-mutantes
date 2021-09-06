using System;

namespace Service
{
    public class CarrinhoService
    {
        public decimal FecharCarrinho(string sku, decimal valorUnitario, int qtd)
        {
            if (qtd > 99)
            {
                throw new Exception();
            }
            
            return qtd * valorUnitario;
        }
    }
}
