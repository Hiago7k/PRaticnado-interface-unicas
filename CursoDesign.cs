namespace PRaticnado_interface_unica;

internal class CursoDesign : ICurso
{
    public Instrutor instrutor;
    public string NomeDoCurso { get; set; }

    public CursoDesign(string nomedocruso, Instrutor instrutor)
    {
        NomeDoCurso = nomedocruso;
        this.instrutor = instrutor;

    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteudo {NomeDoCurso}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: DE DESIGN {NomeDoCurso} {instrutor.Especialidade}");
    }
}
