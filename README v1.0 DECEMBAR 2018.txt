***************************************************************
README v1.0 / DECEMBAR 2018.
***************************************************************

# Projekat škola

## Uvod (Introduction)

Projekat škola predstavlja veb aplikaciju uz pomoć koje korisnici mogu, u zavisnosti od nivoa pristupa, izvršavati neke osnovne komande (unos, izmena, brisanje, štampanje..) nad formom koja sadrži informacije o školama i njenim kontaktima.

https://imgur.com/uNd8DS3

PRE NEGO ŠTO POČNETE, NEOPHODNO JE DA PROČITATE UPUTSTVA!!!




## Uputstva (Guide instructions)

*** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO ***
*** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO ***

1. Preuzmite repozitorijum pod nazivom "PROJEKAT" na GitHub-u (Clone or download - DOWNLOAD ZIP).

2. Nakon što preuzmete repozitorijum "PROJEKAT", neophodno je da iz foldera "Baza podataka", oba fajla (BazaProjekat.mdf i BazaProjekat_log.ldf) prebacite/kopirate u Vaš DATA folder MS SQL Servera,a on se obično nalazi u: C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA

3. Nakon što ste to uradili, pokrenite MS SQL Server
 - Desni klik na DATABASES u padajućem meniju ispod imena Vaše baze u "Object Exploreru" i kliknite na "ATTACH"
 - Nakon toga Vam se otvori prozor "Attach databases" i u njemu "Databases to Attach" kliknite na dugme za dodavanje  --- > "Add" <---
 - Trebalo bi da Vam se otvori po default-u DATA folder gde ste prebacili neophodne fajlove (BazaProjekat.mdf i BazaProjekat_log.ldf), a ako se kojim slučajem nije otvorio, pronađite ga sami na : C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA
 - OBELEŽITE FAJL BazaProjekat.mdf i kliknite "Ok".

4. Uspešno ste ubacili bazu neophodnu za ovaj projekat, ostalo je još samo da u samom projektu u Microsoft Visual Studiu, postavite vaše ime baze, a to ćete uraditi na sledeći način.

5. Pokrenite fajl/solution "ProjekatFinalni.sln"

6. Nakon što Vam se otvori, na DNU prozora "Solution Explorer", stajaće fajl Web.config, otvorite ga.

7. Izmedju <connectionStrings></connectionStrings>, treba da pronađete "data source = DUKA" i umesto imena naše baze "DUKA", postavite ime Vaše Baze (Videti u MS SQL Serveru u "Object Exploreru"). Ponovite to svuda gde piše "data source = DUKA". 

**PrtScr** https://imgur.com/a/DMibANp 

8. Nakon što ste završili sve navedene stavke, pokušajte da pokrenete aplikaciju CTRL + F5.

9. U slučaju da aplikacija radi normalno, nastavite sa čitanjem "Načina korišćenja". Ukoliko ne radi, pročitajte "Pomoć".

*** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO ***
*** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO *** VAŽNO ***



## Način korišćenja (Usage instructions)

1. Pokretanje aplikacije

- Nakon što ste pokrenuli aplikaciju, pojaviće vam se početna stranica koja daje kratak opis o veb aplikaciji, nastavite dalje klikom na dugme "Započni>>", naredna stvar koja će se pokrenuti je stranica za prijavu, ukoliko se već niste registrovali, morate to učiniti klikom na link "Registracija".

2. Registracija

- Jedan od važnijih koraka pri korišćenju aplikacije je "Registracija". U prostor namenjen za unos podataka, unesite "Korisničko ime", kratko ime koje ćete koristiti kada se budete prijavljivali. Sledeća stavka je "Lozinka", pažljivo odaberite Vašu lozinku, savetujemo Vam da sadrži minimum 8 cifara, koristite mešavinu velikih i malih slova kao i brojeva. Sledi odabir vrste naloga koji želite da koristite u skladu sa tim kakav stepen pristupa želite:

** Admin ** Poseduje maksimalan pristup podacima, i sa njim ćete moći da imate totalnu kontrolu nad podacima veb aplikacije, kako nad informacijama o školama, tako i nad registrovanim korisnicima.

** Gost ** Ima mogućnost pregleda škola i informacijama o njima, kao i opciju za štampanje potrebnih informacija, ostale mogućnosti su za njega zaključane.

** Pravo za unos "" Ova vrsta naloga Vam omogućava, izmenu informacija o postojećim školama, kao i mogućnost kreiranja nove i naravno mogućnost štampanja stranice.

Da bi se uspešno registrovali, kliknite na "Kreiraj".

3. Prijava

- Nakon što ste se registrovali, neophodno je da se prijavite. Unesite korisničko ime koje ste izabrali kao i lozinku za validaciju i kliknite "Prijavi se".

4. Lista škola

- Ako je prijava bila uspešna, pojaviće se Vaše korisničko ime u gornjem desnom ćošku,a prva stranica koja će nakon prijave biti pokrenuta je "Lista škola". Na kojoj se nalaze nazivi škola i informacije o njima, naravno ukoliko postoji neka škola uneta u bazu podataka. Ukoliko ste napravili nalog sa nivoom pristupa "Admin" ili "Pravo za unos" imaćete mogućnost dodavanja nove škole, a "Admin" takođe može da menja informacije o već postojećim školama kao i da ih briše. 

5. Napravi novu školu

- Prilikom dodavanja nove škole, morate popuniti obrazac za kreiranje nove škole. Neophodno je uneti sve bitne podatke, ukoliko to ne učinite, pojaviće se poruka koja Vam nalaže da to učinite.

6. Izmeni - Obriši

** Izmeni ** Možete menjati informacije o unetim školama klikom na dugme "Izmeni", nakon toga možete izmeniti željene podatke i sačuvati ih na dugme "Sačuvaj". 

** Obriši ** Takođe možete i obrisati unete škole, klikom na dugme "Obriši".


7. Informacije o kontaktima

- Sada kada ste dodali novu školu, dodatnim informacijama o kontaktima možete pristupiti klikom na naziv željene škole. Pojaviće Vam se nova stranica o informacijama u vezi kontakata (zaposlenih) u toj školi, klikom na "Email" i "Telefoni" u sklopu kontakta, možete pristupiti sadržaju. 

8. Komandna linija

- Tokom rada aplikacije, nebitno na kojoj stranici se nalazite, iznad će stajati komandna linija tirkizne boje, pomoću koje ćete lako moći da se krećete kroz aplikaciju, tu se pored prečice za Listu škola i Vašeg korisničkog imena, nalazi i prečica za odjavu sa aplikacije. Korisnik sa nivoom pristupa "Admin" će još imati prečicu "Korisnici" uz pomoć koje će moći da pristupi registrovanim korisnicima aplikacije.

9. Korisnici

- Kao admin, možete da manipulišete već postojećim korisnicima, da menjate njihova prava pristupa, da im resetujete lozinku ili da ih u potpunosti obrišete. Takođe, možete da kreirate i novog korisnika i da mu po Vašoj volji dodelite šifru i prava pristupa.

** Promeni prava korisnika ** Klikom na link, promeni prava korisnika, otvara Vam se stranica na kojoj ćete moći da promenite pravo pristupa za željenog korisnika, a klikom na dugme "Promeni" da izvršite promenu.

** Obriši korisnika ** Pojaviće Vam se nova stranica koja će Vas upitati da li ste sigurni da zaista želite da obrišete odabranog korisnika, a klikom na dugme, "Obriši" to potvrđujete.

** Resetuj lozinku korisinika ** Ovde možete resetovati lozinku bilo kog korisnika, unesite dva puta željenu lozinku, drugi put kako bi je potvrdili, a klikom na dugme "Resetuj", lozinka će biti resetovana.


### Pomoć (Help)


- Polazimo od pretpostavke da koristite Microsoft Visual Studio 2017 i imate instalirane sve neophodne dodatke za ASP.NET.

*******Učestali problemi*******

[1]
Da biste koristili aplikaciju nesmetano, neophodno je da su Vam NuGet Packages(paketi) ažurirani. Ukoliko nisu, desnim klikom na ime projekta u "Solution explorer/ProjekatFinalni" kliknite na "Manage NuGet packages" u otvorenom prozoru kliknite na dugme "Browse" i prekopirajte ovaj tekst "Microsoft.CodeDom.Providers.DotNetCompilerPlatform". Skinite ekstenziju koja Vam se pojavila i instalirajte je. Ponovo pokrenite projekat za svaki slučaj.

[2]
Could not find a part of the path '...\bin\roslyn\csc.exe'.

U slučaju ovog problema, neophodno je da pronadjete fajl sa ektenzijom .csproj i da u njega prekopirate kod ispod.

<Target Name="CopyRoslynFiles" AfterTargets="AfterBuild" Condition="!$(Disable_CopyWebApplication) And '$(OutDir)' != '$(OutputPath)'">
    <ItemGroup>
      <RoslynFiles Include="$(CscToolPath)\*" />
    </ItemGroup>
    <MakeDir Directories="$(WebProjectOutputDir)\bin\roslyn" />
    <Copy SourceFiles="@(RoslynFiles)" DestinationFolder="$(WebProjectOutputDir)\bin\roslyn" SkipUnchangedFiles="true" Retries="$(CopyRetryCount)" RetryDelayMilliseconds="$(CopyRetryDelayMilliseconds)" />
</Target>



- U slučaju drugih problema kontaktirajte nas mejlom na:
dusan59517@its.edu.rs 


### Neophodne aplikacije (Requirements)

1. Microsoft Visual Studio 2017

2. Microsoft SQL Server


### Projektanti (Project Contributors - Credits)

1. Marina Jevremović - RM
2. Nikola Jevremović - IT
3. Dušan Jovičić - IT
4. Aleksandar Vuković - IT
5. Luka Brdar - IT

### Kontakt (Contact)

E-mail: dusan59517@its.edu.rs


------------------------------------------------------------------------------------

Prosleđene informacije su namenjene isključivo osobama ili entitetima na koje je poruka adresirana. Bilo kakvo širenje informacija, njihovo kopiranje i parafraziranje ili bilo koja druga upotreba ili preduzimanje akcije od strane lica ili entiteta na koje poruka nije adresirana, a vezano za informacije iz poruke i bez izričite dozvole pošiljaoca se zabranjuje. Pošiljalac nije odgovoran ni za kakav prenos komunikacija, niti za kašnjenje poruke. 

The information transmitted is intended only for the person or entity to which it is addressed. Any review, retransmission, dissemination or other use of, or taking of any action in reliance upon this information by persons or entities other than the intended recipient - without the sender's explicit permission - is prohibited. The sender is neither liable for the proper transmission of this communication nor for any delay in its receipt.




 







