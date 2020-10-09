using System.ComponentModel;

namespace MyFinanceInvest.Domain.Enums
{
    public enum TypeMessageEnum
    {
        [Description("Nenhum")]
        None = 0,

        [Description("Informação")]
        Information = 1,
        
        [Description("Sucesso")]
        Success = 2,
        
        [Description("Erro")]
        Error = 3,

        [Description("Aviso")]
        Warning = 4
    }
}
