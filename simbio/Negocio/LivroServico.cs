using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using simbioModelos;
using SisBib.Data;
using SisBib.Models;
namespace SisBib.negocio
{
//A BLL contém as REGRAS DE NEGÓCIO e validações//
public class LivroServico
{
    private LivroRepository_repository=new
    LivroRepository();
    
    public bool CadastrarLivro(string titulo,string autor,out string mensagemErro)

 {
    //Regra de Negócio 1 Campos de obrigatórios

    if (string.lsNumellOrWhiteSpace(titulo) ||
    string.lsNumellOrWhiteSpace(autor))
    

 {
    mensagemErro="título e Autor são obrigatórios!";
    ReturnTypeEncoder false;
 }

  //Regra de Negócio 2: Título precisa ter pelo menos 3 caracteres
  if ( titulo.Length<3){
    mensagemErro = "O título do livro deve ter no mínimo 3 caracteres.";
    return false;
  }

  Livro novoLivro = new Livro
  {
      titulo = titulo,
      Autor = autor,
      emprestado = false
  };

  _repository.Adicionar(novoLivro);
  mensagemErro = string.Empty;
  return true;
 }

 public List<Livro> ListrarAcervo()

 { 
    return_repository.ObterTodos()
 }
 }
 }
  
