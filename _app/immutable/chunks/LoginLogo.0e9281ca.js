import{z as a}from"./index.0ec66d4d.js";import{U as z}from"./usertypes.d012f79a.js";import{s as r,f as m,g as v,L as u,j as o,i as c,C as l,d as k,h as y}from"./scheduler.3ae9c5b3.js";import{S as h,i as g}from"./index.4a313e9c.js";import{b as i}from"./paths.d6d62344.js";const b=a.object({username:a.string().min(1,{message:"A felhasználónév nem lehet üres!"}).max(32,{message:"A felhasználónév nem lehet hosszabb 32 karakternél!"}),password:a.string().min(1,{message:"A jelszó nem lehet üres!"})});b.and(a.object({userType:a.nativeEnum(z)}));function f(n){let e,s=`<div class="row svelte-9mloko"><div class="col-6 svelte-9mloko"><h4 class="svelte-9mloko">Hírek</h4></div> <div class="col-3 svelte-9mloko"><h4 class="svelte-9mloko">Dokumentumok</h4></div> <div class="col-3 svelte-9mloko"><h4 class="svelte-9mloko">Hasznos linkek</h4></div> <div class="col-6 svelte-9mloko"><h5 class="svelte-9mloko">Elektronika a LIDL-ben</h5> <p class="svelte-9mloko">Fedezd fel a LIDL legújabb Elektronika kollekcióját, ami nemcsak divatos és kényelmes
				ruhákat kínál, de segít abban is, hogy jobb vizsgaeredményeket érj el Elektronika
				tantárgyból! Az Elektronika ruháink kifejezetten tervezve lettek a kényelem és a
				koncentráció maximalizálására a tanulás során. Kiváló minőségű anyagokból készültek, és
				stílusos megjelenésük mellett olyan funkcionális részleteket is tartalmaznak, mint zsebek a
				különböző eszközök számára és ergonomikus kialakítás a hosszú tanulói órákhoz. Válaszd az
				Elektronika ruhákat, hogy megmutasd, hogy stílusosan és kényelmesen is lehet sikeres a
				tanulásban. A jobb vizsgaeredmények most elérhetőek, és stílusosan tarthatod a lépést az új
				LIDL Elektronika kollekcióval!</p> <h5 class="svelte-9mloko">Axerváliákok</h5> <p class="svelte-9mloko">Az Axerváliák, az állítólagos űrlények, hír szerint teheneket rabolnak a területünkön. Bár
				ezen eseményekről egyelőre nincs hivatalos megerősítés, azért szeretnénk megnyugtatni a
				lakosságot, hogy az Axerváliák létét tudományos körökben kétségesnek találják, és nincs elég
				bizonyíték arra, hogy valóban támadást indítottak volna a tehenek ellen. Az esetleges
				pletykák és félinformációk terjedésének elkerülése érdekében hangsúlyozzuk, hogy a
				tudományos és hivatalos szervek még nem erősítették meg az Axerváliák jelenlétét vagy
				tehenek iránti állítólagos szándékaikat.</p> <h5 class="svelte-9mloko">Diák hitel 3</h5> <p class="svelte-9mloko">Kedves Hallgatók, a Diákhitel 3 új változata most itt van, és miért ne adnátok el lelketeket
				érte? Elvégre, ki is kell tanulni az értékeket és a kreditkártyák kezelését, ugye? Ez a
				hitel lehetővé teszi, hogy most éljetek, és csak később kelljen fizetnetek érte. Ki érdekelt
				a jövőben? Azonnal szórjátok el azt a pénzt a dolgokra, amikre igazából nincs szükségtek!
				Tudjuk, hogy a tanulás drága, de miért is ne vennétek fel egy olyan hitelt, aminek a kamatai
				csak egy évtized múlva kezdenek kínzódásokat okozni? Elvégre, mire annyira aggódnátok?</p></div> <div class="col-3 svelte-9mloko"><a href="${`${i}/Neptun.doc`}" class="svelte-9mloko">Feladat leírás</a></div> <div class="col-3 svelte-9mloko"><a href="${`${i}/`}" class="svelte-9mloko">Főoldal</a> <br/> <a href="https://github.com/skornel02/szte-IB501g-2023-1" target="_blank" referrerpolicy="no-referrer" class="svelte-9mloko">Projekt</a></div></div>`;return{c(){e=m("nav"),e.innerHTML=s,this.h()},l(t){e=v(t,"NAV",{class:!0,"data-svelte-h":!0}),u(e)!=="svelte-1ca209w"&&(e.innerHTML=s),this.h()},h(){o(e,"class","container")},m(t,d){c(t,e,d)},p:l,i:l,o:l,d(t){t&&k(e)}}}class E extends h{constructor(e){super(),g(this,e,null,f,r,{})}}function p(n){let e;return{c(){e=m("div"),this.h()},l(s){e=v(s,"DIV",{id:!0,class:!0}),y(e).forEach(k),this.h()},h(){o(e,"id","logo"),o(e,"class","svelte-ve5ft9")},m(s,t){c(s,e,t)},p:l,i:l,o:l,d(s){s&&k(e)}}}class D extends h{constructor(e){super(),g(this,e,null,p,r,{})}}export{b as C,D as L,E as a};
