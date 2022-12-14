cd music-info-app
dotnet ef database update
Start-Job -ScriptBlock {dotnet run}

Start-Sleep -Seconds 5


$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("Content-Type", "application/json")

$body = "{
`n  `"name`": `"Nothing More`",
`n  `"about`": `"Rock Band`",
`n  `"albums`": [
`n    {
`n      `"name`": `"The Stories We Tell Ourselves`",
`n      `"songs`": [
`n        {
`n          `"title`": `"Go To War`",
`n          `"lyrics`": `"I don't know what you had in mind But here we stand on opposing sidesLet's go to war Let's go to war We arm ourselves with the wrongs we've done Name them off one by one Let's go to war Let's go to war`",
`n          `"duration`": 245,
`n          `"listenerCount`": 61627389
`n        },
`n        {
`n          `"title`": `"Fade In / Fade Out`",
`n          `"lyrics`": `"Just the other day I looked at my father It was the first time I saw he'd grown old Canyons through his skin and the rivers that made them Carved the stories I was told`",
`n          `"duration`": 365,
`n          `"listenerCount`": 25027042
`n        }
`n      ],
`n      `"songCount`": 2
`n    }
`n  ]
`n}"

$response = Invoke-RestMethod 'https://localhost:7166/api/Artists' -Method 'POST' -Headers $headers -Body $body
$response | ConvertTo-Json



$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("Content-Type", "application/json")

$body = "{
`n  `"name`": `"Cem Karaca`",
`n  `"about`": `"Anadolu Rock'ın kralı`",
`n  `"albums`": [
`n    {
`n      `"name`": `"Yiyin Efendiler`",
`n      `"songs`": [
`n        {
`n          `"title`": `"Yiyin Efendiler`",
`n          `"lyrics`": `"Bu sofracık efendiler Halkımızın varı yoğu hayatı Kan ağlayan can çekişen halkımızın Bekler sizi efendiler Önünüzde titrer durur Ama sakın çekinmeyin Yiyin yutun, yiyin yutun, iyin yutun şapur şupur`",
`n          `"duration`": 271,
`n          `"listenerCount`": 1124572
`n        },
`n        {
`n          `"title`": `"Kirlenmiş Çığlık`",
`n          `"lyrics`": `"Yalanan yutulan her lokmada Gizlenmiş bir kirlenmiş çığlık Hiroşima'daki bulutlar değil ama ustam Dondurmalar bile zehirli artık Çiçekler çiçek gibi kokmuyor artık Ve doğa nasıl yırtık Bu günah dolu miras ey Allahım Çocuklarımıza nasıl bıraktık`",
`n          `"duration`": 445,
`n          `"listenerCount`": 287435
`n        }
`n      ],
`n      `"songCount`": 2
`n    }
`n  ]
`n}"

$response = Invoke-RestMethod 'https://localhost:7166/api/Artists' -Method 'POST' -Headers $headers -Body $body
$response | ConvertTo-Json


$headers = New-Object "System.Collections.Generic.Dictionary[[String],[String]]"
$headers.Add("Content-Type", "application/json")

$body = "{
`n  `"name`": `"maNga`",
`n  `"about`": `"Türk Rock Grubu`",
`n  `"albums`": [
`n    {
`n      `"name`": `"Şehr-i Hüzün`",
`n      `"songs`": [
`n        {
`n          `"title`": `"Cevapsız Sorular`",
`n          `"lyrics`": `"Birden ay ışığını kesti Birde sen çok değiştin Yaşananlar hiç yaşanmamış gibi Söylenenler hiç söylenmemiş gibi`",
`n          `"duration`": 272,
`n          `"listenerCount`": 69296980
`n        },
`n        {
`n          `"title`": `"Beni Benimle Bırak`",
`n          `"lyrics`": `"Al bu dünya, al senin olsun Benim hiç gözüm yok, hepsi senin olsun Ama son bir dileğim var senden şu gaybana dünyada Varını, yoğunu al, hepsini al da`",
`n          `"duration`": 209,
`n          `"listenerCount`": 26213310
`n        }
`n      ],
`n      `"songCount`": 2
`n    }
`n  ]
`n}"

$response = Invoke-RestMethod 'https://localhost:7166/api/Artists' -Method 'POST' -Headers $headers -Body $body
$response | ConvertTo-Json

Read-Host -Prompt "Press any key to continue"