import{a as vt}from"../chunks/js.cookie.edb2da2a.js";import{b as rt}from"../chunks/paths.d6d62344.js";import{E as ct}from"../chunks/ExamDto.2ccd907e.js";import{s as pt,f as n,a as g,g as d,h as E,L as X,c as C,d as m,j as J,i as nt,x as e,y as dt,C as it,M as ht,l as H,m as L,n as U}from"../chunks/scheduler.3ae9c5b3.js";import{e as at}from"../chunks/each.ed53a14b.js";import{S as bt,i as Tt}from"../chunks/index.4a313e9c.js";import{i as Et}from"../chunks/navigation.f96f0522.js";import{t as ot}from"../chunks/SvelteToast.svelte_svelte_type_style_lang.eae3c669.js";import{E as lt}from"../chunks/examtypes.71cfa446.js";import{E as gt}from"../chunks/ErrorResponseDto.3330ec0e.js";const Ct=async({fetch:a})=>{const t=vt.get("hallgato-token");let c=[],h=[];try{const b=await(await a(rt+"/api/exams?attendedByMe=true",{method:"GET",headers:{Authorization:`Bearer ${t}`,"Content-Type":"application/json"}})).json();c=await ct.parseAsync(b)}catch(p){console.error("Teacher statistics failed!",p)}try{const b=await(await a(rt+"/api/exams",{method:"GET",headers:{Authorization:`Bearer ${t}`,"Content-Type":"application/json"}})).json();h=(await ct.parseAsync(b)).filter(u=>!c.some(k=>k.courseCode===u.courseCode&&k.courseSemester===u.courseSemester&&k.start===u.start))}catch(p){console.error("Teacher statistics failed!",p)}return{attendedExams:c,exams:h}},Ht=Object.freeze(Object.defineProperty({__proto__:null,load:Ct},Symbol.toStringTag,{value:"Module"}));function ut(a,t,c){const h=a.slice();return h[5]=t[c],h}function ft(a,t,c){const h=a.slice();return h[5]=t[c],h}function mt(a){let t,c,h=a[5].courseCode+"",p,b,u,k=a[5].courseSemester+"",f,w,B,R=a[5].start+"",D,M,j,S=a[5].end+"",y,$,z,O=lt(a[5].examType)+"",I,x,T,V=a[5].classRoomAddress+"",q,F,N=a[5].classRoomNumber+"",Y,K,r,_,v="Lead",o,i,l;function P(){return a[3](a[5])}return{c(){t=n("tr"),c=n("td"),p=H(h),b=g(),u=n("td"),f=H(k),w=g(),B=n("td"),D=H(R),M=g(),j=n("td"),y=H(S),$=g(),z=n("td"),I=H(O),x=g(),T=n("td"),q=H(V),F=H(", "),Y=H(N),K=g(),r=n("td"),_=n("button"),_.textContent=v,o=g(),this.h()},l(A){t=d(A,"TR",{});var s=E(t);c=d(s,"TD",{});var W=E(c);p=L(W,h),W.forEach(m),b=C(s),u=d(s,"TD",{});var G=E(u);f=L(G,k),G.forEach(m),w=C(s),B=d(s,"TD",{});var Z=E(B);D=L(Z,R),Z.forEach(m),M=C(s),j=d(s,"TD",{});var tt=E(j);y=L(tt,S),tt.forEach(m),$=C(s),z=d(s,"TD",{});var et=E(z);I=L(et,O),et.forEach(m),x=C(s),T=d(s,"TD",{});var Q=E(T);q=L(Q,V),F=L(Q,", "),Y=L(Q,N),Q.forEach(m),K=C(s),r=d(s,"TD",{class:!0});var st=E(r);_=d(st,"BUTTON",{class:!0,"data-svelte-h":!0}),X(_)!=="svelte-1eq5t16"&&(_.textContent=v),st.forEach(m),o=C(s),s.forEach(m),this.h()},h(){J(_,"class","btn-small btn-danger"),J(r,"class","table-commands")},m(A,s){nt(A,t,s),e(t,c),e(c,p),e(t,b),e(t,u),e(u,f),e(t,w),e(t,B),e(B,D),e(t,M),e(t,j),e(j,y),e(t,$),e(t,z),e(z,I),e(t,x),e(t,T),e(T,q),e(T,F),e(T,Y),e(t,K),e(t,r),e(r,_),e(t,o),i||(l=dt(_,"click",P),i=!0)},p(A,s){a=A,s&1&&h!==(h=a[5].courseCode+"")&&U(p,h),s&1&&k!==(k=a[5].courseSemester+"")&&U(f,k),s&1&&R!==(R=a[5].start+"")&&U(D,R),s&1&&S!==(S=a[5].end+"")&&U(y,S),s&1&&O!==(O=lt(a[5].examType)+"")&&U(I,O),s&1&&V!==(V=a[5].classRoomAddress+"")&&U(q,V),s&1&&N!==(N=a[5].classRoomNumber+"")&&U(Y,N)},d(A){A&&m(t),i=!1,l()}}}function _t(a){let t,c,h=a[5].courseCode+"",p,b,u,k=a[5].courseSemester+"",f,w,B,R=a[5].start+"",D,M,j,S=a[5].end+"",y,$,z,O=lt(a[5].examType)+"",I,x,T,V=a[5].classRoomAddress+"",q,F,N=a[5].classRoomNumber+"",Y,K,r,_,v="Felvesz",o,i,l;function P(){return a[4](a[5])}return{c(){t=n("tr"),c=n("td"),p=H(h),b=g(),u=n("td"),f=H(k),w=g(),B=n("td"),D=H(R),M=g(),j=n("td"),y=H(S),$=g(),z=n("td"),I=H(O),x=g(),T=n("td"),q=H(V),F=H(", "),Y=H(N),K=g(),r=n("td"),_=n("button"),_.textContent=v,o=g(),this.h()},l(A){t=d(A,"TR",{});var s=E(t);c=d(s,"TD",{});var W=E(c);p=L(W,h),W.forEach(m),b=C(s),u=d(s,"TD",{});var G=E(u);f=L(G,k),G.forEach(m),w=C(s),B=d(s,"TD",{});var Z=E(B);D=L(Z,R),Z.forEach(m),M=C(s),j=d(s,"TD",{});var tt=E(j);y=L(tt,S),tt.forEach(m),$=C(s),z=d(s,"TD",{});var et=E(z);I=L(et,O),et.forEach(m),x=C(s),T=d(s,"TD",{});var Q=E(T);q=L(Q,V),F=L(Q,", "),Y=L(Q,N),Q.forEach(m),K=C(s),r=d(s,"TD",{class:!0});var st=E(r);_=d(st,"BUTTON",{class:!0,"data-svelte-h":!0}),X(_)!=="svelte-2kg0n6"&&(_.textContent=v),st.forEach(m),o=C(s),s.forEach(m),this.h()},h(){J(_,"class","btn-small"),J(r,"class","table-commands")},m(A,s){nt(A,t,s),e(t,c),e(c,p),e(t,b),e(t,u),e(u,f),e(t,w),e(t,B),e(B,D),e(t,M),e(t,j),e(j,y),e(t,$),e(t,z),e(z,I),e(t,x),e(t,T),e(T,q),e(T,F),e(T,Y),e(t,K),e(t,r),e(r,_),e(t,o),i||(l=dt(_,"click",P),i=!0)},p(A,s){a=A,s&1&&h!==(h=a[5].courseCode+"")&&U(p,h),s&1&&k!==(k=a[5].courseSemester+"")&&U(f,k),s&1&&R!==(R=a[5].start+"")&&U(D,R),s&1&&S!==(S=a[5].end+"")&&U(y,S),s&1&&O!==(O=lt(a[5].examType)+"")&&U(I,O),s&1&&V!==(V=a[5].classRoomAddress+"")&&U(q,V),s&1&&N!==(N=a[5].classRoomNumber+"")&&U(Y,N)},d(A){A&&m(t),i=!1,l()}}}function kt(a){let t,c,h="Vizsgák",p,b,u,k="Frissítés",f,w,B="Általam felvett vizsgák",R,D,M,j="<tr><th>Kód</th> <th>Szemeszter</th> <th>Kezdet</th> <th>Vége</th> <th>Típus</th> <th>Terem</th> <th>Műveletek</th></tr>",S,y,$,z,O="További vizsgák",I,x,T,V="<tr><th>Kód</th> <th>Szemeszter</th> <th>Kezdet</th> <th>Vég</th> <th>Típus</th> <th>Terem</th> <th>Műveletek</th></tr>",q,F,N,Y,K=at(a[0].attendedExams),r=[];for(let o=0;o<K.length;o+=1)r[o]=mt(ft(a,K,o));let _=at(a[0].exams),v=[];for(let o=0;o<_.length;o+=1)v[o]=_t(ut(a,_,o));return{c(){t=n("div"),c=n("h4"),c.textContent=h,p=g(),b=n("div"),u=n("button"),u.textContent=k,f=g(),w=n("h5"),w.textContent=B,R=g(),D=n("table"),M=n("thead"),M.innerHTML=j,S=g(),y=n("tbody");for(let o=0;o<r.length;o+=1)r[o].c();$=g(),z=n("h5"),z.textContent=O,I=g(),x=n("table"),T=n("thead"),T.innerHTML=V,q=g(),F=n("tbody");for(let o=0;o<v.length;o+=1)v[o].c();this.h()},l(o){t=d(o,"DIV",{class:!0});var i=E(t);c=d(i,"H4",{class:!0,"data-svelte-h":!0}),X(c)!=="svelte-9hyc3"&&(c.textContent=h),p=C(i),b=d(i,"DIV",{class:!0});var l=E(b);u=d(l,"BUTTON",{class:!0,"data-svelte-h":!0}),X(u)!=="svelte-cxj7cd"&&(u.textContent=k),l.forEach(m),f=C(i),w=d(i,"H5",{"data-svelte-h":!0}),X(w)!=="svelte-lt1dx9"&&(w.textContent=B),R=C(i),D=d(i,"TABLE",{class:!0});var P=E(D);M=d(P,"THEAD",{"data-svelte-h":!0}),X(M)!=="svelte-r9mz7e"&&(M.innerHTML=j),S=C(P),y=d(P,"TBODY",{});var A=E(y);for(let G=0;G<r.length;G+=1)r[G].l(A);A.forEach(m),P.forEach(m),$=C(i),z=d(i,"H5",{"data-svelte-h":!0}),X(z)!=="svelte-fyk0wa"&&(z.textContent=O),I=C(i),x=d(i,"TABLE",{class:!0});var s=E(x);T=d(s,"THEAD",{"data-svelte-h":!0}),X(T)!=="svelte-5twfbr"&&(T.innerHTML=V),q=C(s),F=d(s,"TBODY",{});var W=E(F);for(let G=0;G<v.length;G+=1)v[G].l(W);W.forEach(m),s.forEach(m),i.forEach(m),this.h()},h(){J(c,"class","svelte-en0jke"),J(u,"class","btn-small btn-primary"),J(b,"class","toolbar"),J(D,"class","table-hover"),J(x,"class","table-hover"),J(t,"class","container")},m(o,i){nt(o,t,i),e(t,c),e(t,p),e(t,b),e(b,u),e(t,f),e(t,w),e(t,R),e(t,D),e(D,M),e(D,S),e(D,y);for(let l=0;l<r.length;l+=1)r[l]&&r[l].m(y,null);e(t,$),e(t,z),e(t,I),e(t,x),e(x,T),e(x,q),e(x,F);for(let l=0;l<v.length;l+=1)v[l]&&v[l].m(F,null);N||(Y=dt(u,"click",a[1]),N=!0)},p(o,[i]){if(i&5){K=at(o[0].attendedExams);let l;for(l=0;l<K.length;l+=1){const P=ft(o,K,l);r[l]?r[l].p(P,i):(r[l]=mt(P),r[l].c(),r[l].m(y,null))}for(;l<r.length;l+=1)r[l].d(1);r.length=K.length}if(i&5){_=at(o[0].exams);let l;for(l=0;l<_.length;l+=1){const P=ut(o,_,l);v[l]?v[l].p(P,i):(v[l]=_t(P),v[l].c(),v[l].m(F,null))}for(;l<v.length;l+=1)v[l].d(1);v.length=_.length}},i:it,o:it,d(o){o&&m(t),ht(r,o),ht(v,o),N=!1,Y()}}}function Dt(a,t,c){let{data:h}=t;const p=()=>Et(),b=async(f,w,B,R)=>{const D=vt.get("hallgato-token"),M=R==="subscribe"?"POST":"DELETE",j=R==="subscribe"?"feliratkozás":"leiratkozás",S=await fetch(`${rt}/api/exams-learn?code=${f}&semester=${w}&start=${encodeURIComponent(B)}`,{method:M,headers:{Authorization:`Bearer ${D}`,"Content-Type":"application/json"}});if(S.status===204)p(),ot.push(`Sikeresen ${j} müvelet!`);else{const y=await S.json(),$=await gt.safeParseAsync(y);$.success?ot.push($.data.errorMessage):ot.push(`Sikertelen ${j} müvelet!`)}},u=f=>b(f.courseCode,f.courseSemester,f.start,"unsubscribe"),k=f=>b(f.courseCode,f.courseSemester,f.start,"subscribe");return a.$$set=f=>{"data"in f&&c(0,h=f.data)},[h,p,b,u,k]}class Lt extends bt{constructor(t){super(),Tt(this,t,Dt,kt,pt,{data:0})}}export{Lt as component,Ht as universal};
