program grafici;

uses
  Forms,
  main in 'main.pas' {Fmain},
  pgeLicense in 'pgeLicense.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'cerebrum - grafici';
  Application.CreateForm(TFmain, Fmain);
  Application.Run;
end.
