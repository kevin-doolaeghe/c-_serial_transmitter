# Transmission série en C#

## Préparation

Ajouter le répertoire `C:\Windows\Microsoft.NET\Framework\<version>\` à la variable d'environnement `Path` :

```
setx Path "%PATH%;C:\Windows\Microsoft.NET\Framework\v4.0.30319"
```

## Compiler code C# vers DLL

Compiler du code source en C# (`.cs`) vers une bibliothèque (Dynamic Link Library `.dll`) :

```
csc.exe /target:library /out:.\<répertoire>\<bilbiothèque>.dll .\<répertoire>\*.cs
```

## Compiler code C# vers exécutable

Compiler du code source en C# (`.cs`) vers un exécutable (`.exe`)  :

```
csc.exe /out:.\<répertoire>\<exécutable>.exe /r:.\<répertoire>\<bibliothèque>.dll .\<répertoire>\*.cs
```