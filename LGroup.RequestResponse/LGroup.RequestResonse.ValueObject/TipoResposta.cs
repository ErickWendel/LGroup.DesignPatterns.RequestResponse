using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VALUE OBJECT(VO) tambem é um PADRAO DE PROJETO
//Catalogado por Martin Fowler(2010)
//A ideia deste padrao é armazenar dados complementares, dados secundarios que não são relacionados a alguma classe principal.
//Poderia ser utilizado normalmente para armazenar:
//constantes, enuns - que são dados secundarios.
//Esse tipo de informação nunca fica no Model ou no DTO. O local mais coerente seria dentro de um Value Object.
namespace LGroup.RequestResonse.ValueObject
{
   //Só é VO quando não vai pro banco, se for pro banco, pode ser Model, DTO ViewModel

    public enum TipoResposta
    {
        Aviso,
        Erro,
        Sucesso
    }
}
