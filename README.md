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

## URL
https://restoranu-valdymo-sistema.vercel.app/login

## Naudojimas

* CREATE/PUT/DELETE endpointai pasiekiami tik turint admin rolę.
* GET endpointai pasiekiami turint user arba admin rolę.
* /login, /register pasiekiami visų - user/admin/svečias
* Autorizacija naudoja JWT, tokene kaip claim yra pridėta rolė. Bearer token gaunamas per /login endpointą

API docs:
https://old-puma-56.redoc.ly/
Wireframes:

Restaurants list:
<img width="1279" alt="image" src="https://user-images.githubusercontent.com/8914148/207929840-c6ba3a88-cb42-4796-b399-d767ab50faba.png">

Detailed view:
<img width="1142" alt="image" src="https://user-images.githubusercontent.com/8914148/207930018-0212c47a-9908-4b82-bc90-a6d60b3714cf.png">

Create form:
<img width="269" alt="image" src="https://user-images.githubusercontent.com/8914148/207930104-0f7c30f7-66ab-4967-a8a4-56672c41a534.png">

Registration form:
<img width="464" alt="image" src="https://user-images.githubusercontent.com/8914148/207930167-0d9d74a5-eec7-4a2b-9e5f-6c8535092fa3.png">
