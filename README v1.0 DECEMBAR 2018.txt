***************************************************************
README v1.0 / DECEMBAR 2018.
***************************************************************

# Projekat �kola

## Uvod (Introduction)

Projekat �kola predstavlja veb aplikaciju uz pomo� koje korisnici mogu, u zavisnosti od nivoa pristupa, izvr�avati neke osnovne komande (unos, izmena, brisanje, �tampanje..) nad formom koja sadr�i informacije o �kolama i njenim kontaktima.

https://imgur.com/uNd8DS3

PRE NEGO �TO PO�NETE, NEOPHODNO JE DA PRO�ITATE UPUTSTVA!!!




## Uputstva (Guide instructions)

*** VA�NO *** VA�NO *** VA�NO *** VA�NO *** VA�NO *** VA�NO ***
*** VA�NO *** VA�NO *** VA�NO *** VA�NO *** VA�NO *** VA�NO ***

1. Preuzmite repozitorijum pod nazivom "PROJEKAT" na GitHub-u.

2. Nakon �to preuzmete repozitorijum "PROJEKAT", neophodno je da iz foldera "Baza podataka", oba fajla (BazaProjekat.mdf i BazaProjekat_log.ldf) prebacite/kopirate u Va� DATA folder MS SQL Servera,a on se obi�no nalazi u: C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA

3. Nakon �to ste to uradili, pokrenite MS SQL Server
 - Desni klik na DATABASES u padaju�em meniju ispod imena Va�e baze u "Object Exploreru" i kliknite na "ATTACH"
 - Nakon toga Vam se otvori prozor "Attach databases" i u njemu "Databases to Attach" kliknite na dugme za dodavanje  --- > "Add" <---
 - Trebalo bi da Vam se otvori po default-u DATA folder gde ste prebacili neophodne fajlove (BazaProjekat.mdf i BazaProjekat_log.ldf), a ako se kojim slu�ajem nije otvorio, prona�ite ga sami na : C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA
 - OBELE�ITE FAJL BazaProjekat.mdf i kliknite "Ok".

4. Uspe�no ste ubacili bazu neophodnu za ovaj projekat, ostalo je jo� samo da u samom projektu u Microsoft Visual Studiu, postavite va�e ime baze, a to �ete uraditi na slede�i na�in.

5. Pokrenite fajl/solution "ProjekatFinalni.sln"

6. Nakon �to Vam se otvori, na DNU prozora "Solution Explorer", staja�e fajl Web.config, otvorite ga.

7. Izmedju <connectionStrings></connectionStrings>, treba da prona�ete "data source = DUKA" i umesto imena na�e baze "DUKA", postavite ime Va�e Baze (Videti u MS SQL Serveru u "Object Exploreru"). Ponovite to svuda gde pi�e "data source = DUKA". 

**PrtScr** https://imgur.com/a/DMibANp 

8. Nakon �to ste zavr�ili sve navedene stavke, poku�ajte da pokrenete aplikaciju CTRL + F5.

9. U slu�aju da aplikacija radi normalno, nastavite sa �itanjem "Na�ina kori��enja". Ukoliko ne radi, pro�itajte "Pomo�".

*** VA�NO *** VA�NO *** VA�NO *** VA�NO *** VA�NO *** VA�NO ***
*** VA�NO *** VA�NO *** VA�NO *** VA�NO *** VA�NO *** VA�NO ***



## Na�in kori��enja (Usage instructions)

1. Pokretanje aplikacije

- Nakon �to ste pokrenuli aplikaciju, pojavi�e vam se po�etna stranica koja daje kratak opis o veb aplikaciji, nastavite dalje klikom na dugme "Zapo�ni>>", naredna stvar koja �e se pokrenuti je stranica za prijavu, ukoliko se ve� niste registrovali, morate to u�initi klikom na link "Registracija".

2. Registracija

- Jedan od va�nijih koraka pri kori��enju aplikacije je "Registracija". U prostor namenjen za unos podataka, unesite "Korisni�ko ime", kratko ime koje �ete koristiti kada se budete prijavljivali. Slede�a stavka je "Lozinka", pa�ljivo odaberite Va�u lozinku, savetujemo Vam da sadr�i minimum 8 cifara, koristite me�avinu velikih i malih slova kao i brojeva. Sledi odabir vrste naloga koji �elite da koristite u skladu sa tim kakav stepen pristupa �elite:

** Admin ** Poseduje maksimalan pristup podacima, i sa njim �ete mo�i da imate totalnu kontrolu nad podacima veb aplikacije, kako nad informacijama o �kolama, tako i nad registrovanim korisnicima.

** Gost ** Ima mogu�nost pregleda �kola i informacijama o njima, kao i opciju za �tampanje potrebnih informacija, ostale mogu�nosti su za njega zaklju�ane.

** Pravo za unos "" Ova vrsta naloga Vam omogu�ava, izmenu informacija o postoje�im �kolama, kao i mogu�nost kreiranja nove i naravno mogu�nost �tampanja stranice.

Da bi se uspe�no registrovali, kliknite na "Kreiraj".

3. Prijava

- Nakon �to ste se registrovali, neophodno je da se prijavite. Unesite korisni�ko ime koje ste izabrali kao i lozinku za validaciju i kliknite "Prijavi se".

4. Lista �kola

- Ako je prijava bila uspe�na, pojavi�e se Va�e korisni�ko ime u gornjem desnom �o�ku,a prva stranica koja �e nakon prijave biti pokrenuta je "Lista �kola". Na kojoj se nalaze nazivi �kola i informacije o njima, naravno ukoliko postoji neka �kola uneta u bazu podataka. Ukoliko ste napravili nalog sa nivoom pristupa "Admin" ili "Pravo za unos" ima�ete mogu�nost dodavanja nove �kole, a "Admin" tako�e mo�e da menja informacije o ve� postoje�im �kolama kao i da ih bri�e. 

5. Napravi novu �kolu

- Prilikom dodavanja nove �kole, morate popuniti obrazac za kreiranje nove �kole. Neophodno je uneti sve bitne podatke, ukoliko to ne u�inite, pojavi�e se poruka koja Vam nala�e da to u�inite.

6. Izmeni - Obri�i

** Izmeni ** Mo�ete menjati informacije o unetim �kolama klikom na dugme "Izmeni", nakon toga mo�ete izmeniti �eljene podatke i sa�uvati ih na dugme "Sa�uvaj". 

** Obri�i ** Tako�e mo�ete i obrisati unete �kole, klikom na dugme "Obri�i".


7. Informacije o kontaktima

- Sada kada ste dodali novu �kolu, dodatnim informacijama o kontaktima mo�ete pristupiti klikom na naziv �eljene �kole. Pojavi�e Vam se nova stranica o informacijama u vezi kontakata (zaposlenih) u toj �koli, klikom na "Email" i "Telefoni" u sklopu kontakta, mo�ete pristupiti sadr�aju. 

8. Komandna linija

- Tokom rada aplikacije, nebitno na kojoj stranici se nalazite, iznad �e stajati komandna linija tirkizne boje, pomo�u koje �ete lako mo�i da se kre�ete kroz aplikaciju, tu se pored pre�ice za Listu �kola i Va�eg korisni�kog imena, nalazi i pre�ica za odjavu sa aplikacije. Korisnik sa nivoom pristupa "Admin" �e jo� imati pre�icu "Korisnici" uz pomo� koje �e mo�i da pristupi registrovanim korisnicima aplikacije.

9. Korisnici

- Kao admin, mo�ete da manipuli�ete ve� postoje�im korisnicima, da menjate njihova prava pristupa, da im resetujete lozinku ili da ih u potpunosti obri�ete. Tako�e, mo�ete da kreirate i novog korisnika i da mu po Va�oj volji dodelite �ifru i prava pristupa.

** Promeni prava korisnika ** Klikom na link, promeni prava korisnika, otvara Vam se stranica na kojoj �ete mo�i da promenite pravo pristupa za �eljenog korisnika, a klikom na dugme "Promeni" da izvr�ite promenu.

** Obri�i korisnika ** Pojavi�e Vam se nova stranica koja �e Vas upitati da li ste sigurni da zaista �elite da obri�ete odabranog korisnika, a klikom na dugme, "Obri�i" to potvr�ujete.

** Resetuj lozinku korisinika ** Ovde mo�ete resetovati lozinku bilo kog korisnika, unesite dva puta �eljenu lozinku, drugi put kako bi je potvrdili, a klikom na dugme "Resetuj", lozinka �e biti resetovana.


### Pomo� (Help)


- Polazimo od pretpostavke da koristite Microsoft Visual Studio 2017 i imate instalirane sve neophodne dodatke za ASP.NET.

*******U�estali problemi*******

[1]
Da biste koristili aplikaciju nesmetano, neophodno je da su Vam NuGet Packages(paketi) a�urirani. Ukoliko nisu, desnim klikom na ime projekta u "Solution explorer/ProjekatFinalni" kliknite na "Manage NuGet packages" u otvorenom prozoru kliknite na dugme "Browse" i prekopirajte ovaj tekst "Microsoft.CodeDom.Providers.DotNetCompilerPlatform". Skinite ekstenziju koja Vam se pojavila i instalirajte je. Ponovo pokrenite projekat za svaki slu�aj.

[2]
Could not find a part of the path '...\bin\roslyn\csc.exe'.

U slu�aju ovog problema, neophodno je da pronadjete fajl sa ektenzijom .csproj i da u njega prekopirate kod ispod.

<Target Name="CopyRoslynFiles" AfterTargets="AfterBuild" Condition="!$(Disable_CopyWebApplication) And '$(OutDir)' != '$(OutputPath)'">
    <ItemGroup>
      <RoslynFiles Include="$(CscToolPath)\*" />
    </ItemGroup>
    <MakeDir Directories="$(WebProjectOutputDir)\bin\roslyn" />
    <Copy SourceFiles="@(RoslynFiles)" DestinationFolder="$(WebProjectOutputDir)\bin\roslyn" SkipUnchangedFiles="true" Retries="$(CopyRetryCount)" RetryDelayMilliseconds="$(CopyRetryDelayMilliseconds)" />
</Target>



- U slu�aju drugih problema kontaktirajte nas mejlom na:
dusan59517@its.edu.rs 


### Neophodne aplikacije (Requirements)

1. Microsoft Visual Studio 2017

2. Microsoft SQL Server


### Projektanti (Project Contributors - Credits)

1. Marina Jevremovi� - RM
2. Nikola Jevremovi� - IT
3. Du�an Jovi�i� - IT
4. Aleksandar Vukovi� - IT
5. Luka Brdar - IT

### Kontakt (Contact)

E-mail: dusan59517@its.edu.rs


------------------------------------------------------------------------------------

Prosle�ene informacije su namenjene isklju�ivo osobama ili entitetima na koje je poruka adresirana. Bilo kakvo �irenje informacija, njihovo kopiranje i parafraziranje ili bilo koja druga upotreba ili preduzimanje akcije od strane lica ili entiteta na koje poruka nije adresirana, a vezano za informacije iz poruke i bez izri�ite dozvole po�iljaoca se zabranjuje. Po�iljalac nije odgovoran ni za kakav prenos komunikacija, niti za ka�njenje poruke. 

The information transmitted is intended only for the person or entity to which it is addressed. Any review, retransmission, dissemination or other use of, or taking of any action in reliance upon this information by persons or entities other than the intended recipient - without the sender's explicit permission - is prohibited. The sender is neither liable for the proper transmission of this communication nor for any delay in its receipt.




 







