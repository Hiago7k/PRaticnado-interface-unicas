namespace PRaticnado_interface_unica;

internal class CursoProgramacao : ICurso
{
    public Instrutor instrutor;
    public string NomeDoCurso { get; set; }

    public CursoProgramacao(Instrutor instrutor, string nomedocruso)
    {
        this.instrutor = instrutor;
        NomeDoCurso = nomedocruso;
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteudo do cruso de programacao {NomeDoCurso}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: C# {NomeDoCurso} {instrutor.Especialidade}");
    }
}
