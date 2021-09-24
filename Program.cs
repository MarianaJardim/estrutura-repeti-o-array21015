using  System ;

namespace  ArrayColection
{
     programa de aula
    {
        static  void  Main ( string [] args )
        {
            // string [] alunosAMS = nova string [5] {
              // "Beatriz",
              // "Gabriela",
              // "Geovanna",
              // "Maria Julia",
              // "Danielle"
          // };

          // Console.WriteLine (alunosAMS [2]);

          // alunosAMS [2] = "Julia";

         // Console.WriteLine ($ "o novo valor do índice 2 {alunosAMS [2]}");

           // foreach (string Aluno em alunosAMS)
           // {
           //      Console.WriteLine (Aluno);
          // }

          string [] alunosAMS   =   nova   string [ 5 ];
          alunosAMS [ 0 ] =   " Beatriz " ;
          alunosAMS [ 1 ] =   " Gabriela " ;
          alunosAMS [ 2 ] =   " Geovanna " ;
          alunosAMS [ 3 ] =   " Maria Julia" ;
          alunosAMS [ 4 ] =   " Danielle " ;

          Console . WriteLine ( alunosAMS [ 2 ]);

          alunosAMS [ 2 ] =   " Eduarda " ;

          Console . WriteLine ( $ " O novo valor atribuído a essa variável é: { alunosAMS [ 2 ]} " );

          for ( int   i   =   0 ; i   <   alunosAMS . Comprimento ; i  ++ )
          {
               Console . WriteLine ( $ " Os nomes são: { alunosAMS [ i ]} " );
          }

        }
    }
}
