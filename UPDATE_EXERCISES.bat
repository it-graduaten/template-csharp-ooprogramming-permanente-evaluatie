@echo off
setlocal

title OO Programming - Update exercises

echo.
echo ============================================
echo   OO Programming - Update README's
echo ============================================
echo.

"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -ExecutionPolicy Bypass -Command ^
"$ErrorActionPreference = 'Stop'; ^
$templateRepo = 'https://github.com/it-graduaten/template-csharp-ooprogramming-permanente-evaluatie.git'; ^
$tempDir = Join-Path $env:TEMP ('oo-programming-' + [guid]::NewGuid().ToString('N')); ^
$localRoot = '%~dp0'; ^
$updated = 0; ^
$created = 0; ^
try { ^
    Write-Host 'Template repository ophalen...'; ^
    git clone --depth 1 --quiet $templateRepo $tempDir; ^
    if ($LASTEXITCODE -ne 0) { throw 'Git clone is mislukt.' }; ^
    Write-Host ''; ^
    Write-Host 'README bestanden bijwerken...'; ^
    Get-ChildItem -LiteralPath $tempDir -Filter 'README.md' -Recurse -File ^| ForEach-Object { ^
        $relativePath = $_.FullName.Substring($tempDir.Length).TrimStart('\','/'); ^
        $parts = $relativePath -split '[\\/]'; ^
        $valid = $parts.Length -eq 3 -and $parts[0] -match '^(0[1-9]^|10)$' -and $parts[1] -match '^(0[1-9]^|10)_(0[0-9]^|10)$' -and $parts[1].Substring(0,2) -eq $parts[0]; ^
        if ($valid) { ^
            $destination = Join-Path $localRoot $relativePath; ^
            $destinationDir = Split-Path $destination -Parent; ^
            if (-not (Test-Path -LiteralPath $destinationDir)) { ^
                New-Item -ItemType Directory -Path $destinationDir -Force ^| Out-Null ^
            }; ^
            if (Test-Path -LiteralPath $destination) { ^
                Copy-Item -LiteralPath $_.FullName -Destination $destination -Force; ^
                Write-Host ('  Bijgewerkt: ' + $relativePath); ^
                $updated++ ^
            } else { ^
                Copy-Item -LiteralPath $_.FullName -Destination $destination; ^
                Write-Host ('  Nieuw: ' + $relativePath) -ForegroundColor Cyan; ^
                $created++ ^
            } ^
        } ^
    }; ^
    Write-Host ''; ^
    Write-Host 'Klaar!' -ForegroundColor Green; ^
    Write-Host ('  Bijgewerkt: ' + $updated); ^
    Write-Host ('  Nieuw:      ' + $created) ^
} catch { ^
    Write-Host ''; ^
    Write-Host ('FOUT: ' + $_.Exception.Message) -ForegroundColor Red ^
} finally { ^
    if (Test-Path -LiteralPath $tempDir) { Remove-Item -LiteralPath $tempDir -Recurse -Force } ^
}"

echo.
pause