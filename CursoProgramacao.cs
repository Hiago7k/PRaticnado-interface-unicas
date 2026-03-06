namespace PRaticnado_interface_unica;

internal class CursoProgramacao : ICurso
{
    public Instrutor instrutor;
    public string NomeDoCurso { get; set; }

    public CursoProgramacao( string nomedocruso, Instrutor instrutor)
    {
        NomeDoCurso = nomedocruso;
        this.instrutor = instrutor;
        
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteudo do cruso de programacao {NomeDoCurso}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: C# {instrutor.Nome} {instrutor.Especialidade}");
    }
}
