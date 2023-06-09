book365 - internetowa biblioteka

Spis Treści:
1. Konfiguracja przed uruchomieniem
2. Role użytkownika 
3. Funkcjonalności ogólne
4. Funkcjonalności Member
5. Funkcjonalności Admin
6. Dane logowania kont początkowych


1. Konfiguracja przed uruchomieniem:
Co zrobić aby uruchomić aplikacje na swoim komputerze:
- W Visual Studio w zakładce Package Manager Console wpisać komendę: "update-database"
Aplikacja powinna być gotowa do uruchomienia. 
W przypadku problemów proszę wykonać następujące czynności:
- za pomocą NuGetManagera zaktualizować pakiety znajdujące się w Eksplorerze Solucji: Zależności -> Pakiety do wersji 6.0.5.
  - w przypadku gdyby folder był pusty oto następujące pakiety:
    - Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore.Tools
    - Microsoft.Extensions.Identity.Core
- Sprawdzić wersję .NET SDK (Wymagana wersja 6)
Aby łatwo to sprawdzić w CMD wystarczy wpisać komendę "dotnet sdk check"
- Zaktualizować Visual Studio do wersji 2022. Dodatkowo należy zadbać, aby na komputrze znajdowały się konkretne składniki.
  - Można je doinstalować za pomocą funkcji "Modyfikuj" w programie Visual Studio Installer. A oto składniki:
    - Opracowywanie zawartośći dla platformy ASP.NET Core
    - Programowanie aplikacji klasycznych dla platformy .NET
    - Magazynowanie i przetwarzanie danych

Dane logowania kont początkowych:
- Konto Admin:
  - Email: admin@mylibrary.com
  - Hasło: admin
- Konto Member:
  - Email: member@mylibrary.com
  - Hasło: member

  
