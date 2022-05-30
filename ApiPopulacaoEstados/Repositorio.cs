namespace ApiPopulacaoEstados
{
    public class Repositorio
    {
        public static List<EstadosModel> Estados()
        {

            List<EstadosModel> _list = new List<EstadosModel>()
            {new EstadosModel { Uf="São Paulo",Sigla="SP",populacao="46.649.132"} ,
             new EstadosModel { Uf = "Minas Gerais",Sigla="MG", populacao = "21.411.923" },
             new EstadosModel { Uf = "Rio de Janeiro",Sigla="RJ", populacao = "17.463.349" },
             new EstadosModel { Uf = "Bahia",Sigla="BA", populacao = "14.985.284" } ,
             new EstadosModel { Uf = "Paraná",Sigla="PR", populacao = "11.597.484" } ,
            };




            return _list;
        }

        public static List<EstadosModel> Estados(string xsigla)
        {

            List<EstadosModel> _list = new List<EstadosModel>()
            {new EstadosModel { Uf="São Paulo",Sigla="SP",populacao="46.649.132"} ,
             new EstadosModel { Uf = "Minas Gerais",Sigla="MG", populacao = "21.411.923" },
             new EstadosModel { Uf = "Rio de Janeiro",Sigla="RJ", populacao = "17.463.349" },
             new EstadosModel { Uf = "Bahia",Sigla="BA", populacao = "14.985.284" } ,
             new EstadosModel { Uf = "Paraná",Sigla="PR", populacao = "11.597.484" } ,
             new EstadosModel { Uf = "Rio Grande do Sul",Sigla="RS", populacao = "11.466.630" } ,
             new EstadosModel { Uf = "Pernanbuco",Sigla="PE", populacao = "9.674.793" } ,
             new EstadosModel { Uf = "Ceará",Sigla="CE", populacao = "9.240.580" } ,
             new EstadosModel { Uf = "Pará",Sigla="PA", populacao = "8.777.124" } ,
             new EstadosModel { Uf = "Santa Catarina",Sigla="SC", populacao = "7.338.473" } ,
             new EstadosModel { Uf = "Goiás",Sigla="GO", populacao = "7.206.589" } ,
             new EstadosModel { Uf = "Maranhão",Sigla="MA", populacao = "7.153.262" } ,
             new EstadosModel { Uf = "Amazonas",Sigla="AM", populacao = "4.269.995" } ,
             new EstadosModel { Uf = "Espírito Santo",Sigla="ES", populacao = "4.108.508" } ,
             new EstadosModel { Uf = "Paraíba",Sigla="PB", populacao = "4.059.905" } ,
             new EstadosModel { Uf = "Mato Grosso",Sigla="MT", populacao = "3.567.234" } ,
             new EstadosModel { Uf = "Rio Grande do Norte",Sigla="RN", populacao = "3.560.903" } ,
             new EstadosModel { Uf = "Alagoas",Sigla="AL", populacao = "3.365.351" } ,
             new EstadosModel { Uf = "Piauí",Sigla="PI", populacao = "3.289.290" } ,
             new EstadosModel { Uf = "Distrito Federal",Sigla="DF", populacao = "3.094.325" } ,
             new EstadosModel { Uf = "Mato Grosso do Sul",Sigla="MS", populacao = "2.839.188" } ,
             new EstadosModel { Uf = "Sergipe",Sigla="SE", populacao = "2.338.474" } ,
             new EstadosModel { Uf = "Rondônia",Sigla="RO", populacao = "1.815.278" } ,
             new EstadosModel { Uf = "Tocantis",Sigla="TO", populacao = "1.607.363" } ,
             new EstadosModel { Uf = "ACRE",Sigla="AC", populacao = "906.876" } ,
             new EstadosModel { Uf = "Amapá",Sigla="AP", populacao = "877.613" } ,
             new EstadosModel { Uf = " Roraima",Sigla="RR", populacao = "652 713" } ,
            };

            _list = _list.Where(s=> s.Sigla == xsigla).ToList();


            return _list;
        }

    }
}
