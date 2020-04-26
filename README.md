# Aventure
Petit programme pour créer une aventure en texte.

# Preérequis
dotnet core 3.1 sdk
https://dotnet.microsoft.com/download/dotnet-core/3.1

git
https://git-scm.com/download/win

# Comment compiler?

Ouvrez un l'invite de commande et tapez:

``` 
git clone https://github.com/FrancisGrignon/aventure.git`
cd aventure
dotnet build
```

# Comment executer?

Simplement utiliser la commande suivante:

`dotnet run`

# Comment partager?

`dotnet publish -r win-x64 --self-contained=false /p:PublishSingleFile=true -p:PublishDir=.\publish -c release`

Votre programme se trouve dans le dossier "publish". Vous pouvez garder seulement le fichier aventure.exe. Le second fichier sert à débugger l'application.

# Comment modifier l'aventure?

Ouvrir le fichier `Program.cs` avec votre éditeur de texte préféré et modifier votre aventure.