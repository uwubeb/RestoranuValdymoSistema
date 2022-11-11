# RestoranuValdymoSistema
# Sprendžiamo uždavinio aprašymas

## Sistemos paskirtis
Projekto tikslas yra padėti restoranų frančižės vadovui bei jo pavaldiniams valdyti restoranus, t.y. valdyti darbuotojus,
užsakymus, kt.

## Veikimo principas
Sistema susideda iš dviejų dalių: grafinė internetinė sąsąja skirta restoranų frančižės savininkui, individualių restoranų
vadovams, bei aplikacijų programavimo sąsaja (angl. trump. API)

## Funkciniai reikalavimai:

Neregistruotas sistemos vartotojas galės:
1. Peržiūrėti platformos reprezentacinį puslapį
2. Prisijungti prie internetinės aplikacijos

Prisiregistravęs, restorano vadovas galės:
1. Kurti restorano darbuotojus, užsakymus
2. Atleisti darbuotojus, keisti užsakymus
3. Pamatyti restorano apžvalgą

Prisiregistravęs, kompanijos vadovas, galės:
1. Pridėti naują restoraną
2. Redaguoti restoranų duomenis
3. Valdyti personalą:
  3.1 Priskirti restoranui vadovą
  3.2 Valdyti restorano darbuotojus
4. Valdyti užsakymus:
  4.1 Peržiūrėti, keisti užsakymus
  4.2 *Palikti pastabas*
5. Matyti frančižės veiklos apibendrinimą

## Naudojimas
http://20.91.161.241/swagger/index.html

* CREATE/PUT/DELETE endpointai pasiekiami tik turint admin rolę.
* GET endpointai pasiekiami turint user arba admin rolę.
* /login, /register pasiekiami visų - user/admin/svečias
* Autorizacija naudoja JWT, tokene kaip claim yra pridėta rolė. Bearer token gaunamas per /login endpointą
