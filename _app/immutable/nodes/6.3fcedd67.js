import{a as $t}from"../chunks/js.cookie.edb2da2a.js";import{z}from"../chunks/index.0ec66d4d.js";import{b as Dt}from"../chunks/paths.59f0d020.js";import{s as qt,n as ht}from"../chunks/scheduler.e108d1fd.js";import{S as Kt,i as Jt,g as s,s as v,h as r,y as P,c as f,j as b,f as d,k as h,a as dt,x as e,A as zt,m as N,n as O}from"../chunks/index.e36b9a99.js";import{e as ct}from"../chunks/each.e59479a4.js";const Qt=z.object({username:z.string(),name:z.string(),birthDate:z.string(),birthLocation:z.string()}),Wt=z.array(Qt),Xt=z.object({username:z.string(),name:z.string(),courseCount:z.number()}),Zt=z.array(Xt),te=z.object({name:z.string(),username:z.string(),semester:z.string(),hours:z.number()}),ee=z.array(te),ae=async({fetch:o})=>{const a=$t.get("token");let c=[],u=[],m=[];try{const i=await(await o(Dt+"/api/statistics/teachers",{method:"GET",headers:{Authorization:`Bearer ${a}`,"Content-Type":"application/json"}})).json();c=await Wt.parseAsync(i)}catch(l){console.error("Teacher statistics failed!",l)}try{const i=await(await o(Dt+"/api/statistics/teacher-load-level",{method:"GET",headers:{Authorization:`Bearer ${a}`,"Content-Type":"application/json"}})).json();u=await ee.parseAsync(i)}catch(l){console.error("Teacher load level statistics failed!",l)}try{const i=await(await o(Dt+"/api/statistics/students",{method:"GET",headers:{Authorization:`Bearer ${a}`,"Content-Type":"application/json"}})).json();m=await Zt.parseAsync(i)}catch(l){console.error("Student statistics failed!",l)}return{teachers:c,students:m,teacherLoadLevels:u}},he=Object.freeze(Object.defineProperty({__proto__:null,load:ae},Symbol.toStringTag,{value:"Module"}));function Nt(o,a,c){const u=o.slice();return u[4]=a[c],u}function Ot(o,a,c){const u=o.slice();return u[7]=a[c],u}function Vt(o,a,c){const u=o.slice();return u[10]=a[c],u}function Ft(o){let a,c,u=o[10].username+"",m,l,i,A=o[10].name+"",y,w,g,S=o[10].birthDate+"",j,E,T,C=o[10].birthLocation+"",L,B;return{c(){a=s("tr"),c=s("td"),m=N(u),l=v(),i=s("td"),y=N(A),w=v(),g=s("td"),j=N(S),E=v(),T=s("td"),L=N(C),B=v()},l(p){a=r(p,"TR",{});var _=b(a);c=r(_,"TD",{});var V=b(c);m=O(V,u),V.forEach(d),l=f(_),i=r(_,"TD",{});var M=b(i);y=O(M,A),M.forEach(d),w=f(_),g=r(_,"TD",{});var F=b(g);j=O(F,S),F.forEach(d),E=f(_),T=r(_,"TD",{});var H=b(T);L=O(H,C),H.forEach(d),B=f(_),_.forEach(d)},m(p,_){dt(p,a,_),e(a,c),e(c,m),e(a,l),e(a,i),e(i,y),e(a,w),e(a,g),e(g,j),e(a,E),e(a,T),e(T,L),e(a,B)},p:ht,d(p){p&&d(a)}}}function Gt(o){let a,c,u=o[7].username+"",m,l,i,A=o[7].name+"",y,w,g,S=o[7].courseCount+"",j,E;return{c(){a=s("tr"),c=s("td"),m=N(u),l=v(),i=s("td"),y=N(A),w=v(),g=s("td"),j=N(S),E=v()},l(T){a=r(T,"TR",{});var C=b(a);c=r(C,"TD",{});var L=b(c);m=O(L,u),L.forEach(d),l=f(C),i=r(C,"TD",{});var B=b(i);y=O(B,A),B.forEach(d),w=f(C),g=r(C,"TD",{});var p=b(g);j=O(p,S),p.forEach(d),E=f(C),C.forEach(d)},m(T,C){dt(T,a,C),e(a,c),e(c,m),e(a,l),e(a,i),e(i,y),e(a,w),e(a,g),e(g,j),e(a,E)},p:ht,d(T){T&&d(a)}}}function Yt(o){let a,c,u=o[4].name+"",m,l,i,A=o[4].username+"",y,w,g,S=o[4].semester+"",j,E,T,C=o[4].hours+"",L,B;return{c(){a=s("tr"),c=s("td"),m=N(u),l=v(),i=s("td"),y=N(A),w=v(),g=s("td"),j=N(S),E=v(),T=s("td"),L=N(C),B=v()},l(p){a=r(p,"TR",{});var _=b(a);c=r(_,"TD",{});var V=b(c);m=O(V,u),V.forEach(d),l=f(_),i=r(_,"TD",{});var M=b(i);y=O(M,A),M.forEach(d),w=f(_),g=r(_,"TD",{});var F=b(g);j=O(F,S),F.forEach(d),E=f(_),T=r(_,"TD",{});var H=b(T);L=O(H,C),H.forEach(d),B=f(_),_.forEach(d)},m(p,_){dt(p,a,_),e(a,c),e(c,m),e(a,l),e(a,i),e(i,y),e(a,w),e(a,g),e(g,j),e(a,E),e(a,T),e(T,L),e(a,B)},p:ht,d(p){p&&d(a)}}}function le(o){let a,c="Statisztikák",u,m,l,i,A,y,w="Oktatók",g,S,j,E,T="Hallgatók",C,L,B,p,_="Tab 3",V,M,F,H,At="Oktató leterheltség",mt,G,W,St="Az oktatók kilistázva, fiatalabbtól az idősebbig.",pt,q,X,jt="<tr><th>Felhasználó név</th> <th>Név</th> <th>Születési dátum</th> <th>Születési hely</th></tr>",gt,Z,Tt,Y,tt,wt="Hallgatók által felvett kurzus mennyiség, a hallgatók neve ABC szerinti sorrendben.",yt,K,et,Bt="<tr><th>Felhasználó név</th> <th>Név</th> <th>Kurzusok száma</th></tr>",Et,at,Ct,J,Ht="<p>Bacon ipsum dolor sit amet beef venison beef ribs kielbasa...</p>",Lt,$,lt,Rt="Tanárok leterheltsége egyes félévekben. Aki nem tart órát, az nem jelenik meg a listában.",kt,Q,nt,It="<tr><th>Felhasználónév</th> <th>Név</th> <th>Félév</th> <th>Órák száma</th></tr>",xt,st,rt=ct(o[0]),k=[];for(let n=0;n<rt.length;n+=1)k[n]=Ft(Vt(o,rt,n));let ot=ct(o[1]),x=[];for(let n=0;n<ot.length;n+=1)x[n]=Gt(Ot(o,ot,n));let it=ct(o[2]),D=[];for(let n=0;n<it.length;n+=1)D[n]=Yt(Nt(o,it,n));return{c(){a=s("h1"),a.textContent=c,u=v(),m=s("div"),l=s("div"),i=s("input"),A=v(),y=s("label"),y.textContent=w,g=v(),S=s("input"),j=v(),E=s("label"),E.textContent=T,C=v(),L=s("input"),B=v(),p=s("label"),p.textContent=_,V=v(),M=s("input"),F=v(),H=s("label"),H.textContent=At,mt=v(),G=s("div"),W=s("p"),W.textContent=St,pt=v(),q=s("table"),X=s("thead"),X.innerHTML=jt,gt=v(),Z=s("tbody");for(let n=0;n<k.length;n+=1)k[n].c();Tt=v(),Y=s("div"),tt=s("p"),tt.textContent=wt,yt=v(),K=s("table"),et=s("thead"),et.innerHTML=Bt,Et=v(),at=s("tbody");for(let n=0;n<x.length;n+=1)x[n].c();Ct=v(),J=s("div"),J.innerHTML=Ht,Lt=v(),$=s("div"),lt=s("p"),lt.textContent=Rt,kt=v(),Q=s("table"),nt=s("thead"),nt.innerHTML=It,xt=v(),st=s("tbody");for(let n=0;n<D.length;n+=1)D[n].c();this.h()},l(n){a=r(n,"H1",{class:!0,"data-svelte-h":!0}),P(a)!=="svelte-5l8x3o"&&(a.textContent=c),u=f(n),m=r(n,"DIV",{class:!0});var R=b(m);l=r(R,"DIV",{class:!0});var t=b(l);i=r(t,"INPUT",{id:!0,type:!0,name:!0}),A=f(t),y=r(t,"LABEL",{for:!0,"data-svelte-h":!0}),P(y)!=="svelte-1ehvetb"&&(y.textContent=w),g=f(t),S=r(t,"INPUT",{id:!0,type:!0,name:!0}),j=f(t),E=r(t,"LABEL",{for:!0,"data-svelte-h":!0}),P(E)!=="svelte-zs39cg"&&(E.textContent=T),C=f(t),L=r(t,"INPUT",{id:!0,type:!0,name:!0}),B=f(t),p=r(t,"LABEL",{for:!0,"data-svelte-h":!0}),P(p)!=="svelte-zc94nc"&&(p.textContent=_),V=f(t),M=r(t,"INPUT",{id:!0,type:!0,name:!0}),F=f(t),H=r(t,"LABEL",{for:!0,"data-svelte-h":!0}),P(H)!=="svelte-wpx73x"&&(H.textContent=At),mt=f(t),G=r(t,"DIV",{class:!0,id:!0});var I=b(G);W=r(I,"P",{"data-svelte-h":!0}),P(W)!=="svelte-37ekjw"&&(W.textContent=St),pt=f(I),q=r(I,"TABLE",{class:!0});var ut=b(q);X=r(ut,"THEAD",{"data-svelte-h":!0}),P(X)!=="svelte-1cp0opd"&&(X.innerHTML=jt),gt=f(ut),Z=r(ut,"TBODY",{});var Mt=b(Z);for(let U=0;U<k.length;U+=1)k[U].l(Mt);Mt.forEach(d),ut.forEach(d),I.forEach(d),Tt=f(t),Y=r(t,"DIV",{class:!0,id:!0});var vt=b(Y);tt=r(vt,"P",{"data-svelte-h":!0}),P(tt)!=="svelte-1hw3mrc"&&(tt.textContent=wt),yt=f(vt),K=r(vt,"TABLE",{class:!0});var ft=b(K);et=r(ft,"THEAD",{"data-svelte-h":!0}),P(et)!=="svelte-3vxmhf"&&(et.innerHTML=Bt),Et=f(ft),at=r(ft,"TBODY",{});var Pt=b(at);for(let U=0;U<x.length;U+=1)x[U].l(Pt);Pt.forEach(d),ft.forEach(d),vt.forEach(d),Ct=f(t),J=r(t,"DIV",{class:!0,id:!0,"data-svelte-h":!0}),P(J)!=="svelte-180yuyw"&&(J.innerHTML=Ht),Lt=f(t),$=r(t,"DIV",{class:!0,id:!0});var _t=b($);lt=r(_t,"P",{"data-svelte-h":!0}),P(lt)!=="svelte-ynm90j"&&(lt.textContent=Rt),kt=f(_t),Q=r(_t,"TABLE",{class:!0});var bt=b(Q);nt=r(bt,"THEAD",{"data-svelte-h":!0}),P(nt)!=="svelte-aazb5"&&(nt.innerHTML=It),xt=f(bt),st=r(bt,"TBODY",{});var Ut=b(st);for(let U=0;U<D.length;U+=1)D[U].l(Ut);Ut.forEach(d),bt.forEach(d),_t.forEach(d),t.forEach(d),R.forEach(d),this.h()},h(){h(a,"class","svelte-wdyx83"),h(i,"id","tab1"),h(i,"type","radio"),h(i,"name","tabs"),i.checked=!0,h(y,"for","tab1"),h(S,"id","tab2"),h(S,"type","radio"),h(S,"name","tabs"),h(E,"for","tab2"),h(L,"id","tab3"),h(L,"type","radio"),h(L,"name","tabs"),h(p,"for","tab3"),h(M,"id","tab4"),h(M,"type","radio"),h(M,"name","tabs"),h(H,"for","tab4"),h(q,"class","table-hover"),h(G,"class","content"),h(G,"id","content1"),h(K,"class","table-hover"),h(Y,"class","content"),h(Y,"id","content2"),h(J,"class","content"),h(J,"id","content3"),h(Q,"class","table-hover"),h($,"class","content"),h($,"id","content4"),h(l,"class","row flex-spaces tabs"),h(m,"class","container")},m(n,R){dt(n,a,R),dt(n,u,R),dt(n,m,R),e(m,l),e(l,i),e(l,A),e(l,y),e(l,g),e(l,S),e(l,j),e(l,E),e(l,C),e(l,L),e(l,B),e(l,p),e(l,V),e(l,M),e(l,F),e(l,H),e(l,mt),e(l,G),e(G,W),e(G,pt),e(G,q),e(q,X),e(q,gt),e(q,Z);for(let t=0;t<k.length;t+=1)k[t]&&k[t].m(Z,null);e(l,Tt),e(l,Y),e(Y,tt),e(Y,yt),e(Y,K),e(K,et),e(K,Et),e(K,at);for(let t=0;t<x.length;t+=1)x[t]&&x[t].m(at,null);e(l,Ct),e(l,J),e(l,Lt),e(l,$),e($,lt),e($,kt),e($,Q),e(Q,nt),e(Q,xt),e(Q,st);for(let t=0;t<D.length;t+=1)D[t]&&D[t].m(st,null)},p(n,[R]){if(R&1){rt=ct(n[0]);let t;for(t=0;t<rt.length;t+=1){const I=Vt(n,rt,t);k[t]?k[t].p(I,R):(k[t]=Ft(I),k[t].c(),k[t].m(Z,null))}for(;t<k.length;t+=1)k[t].d(1);k.length=rt.length}if(R&2){ot=ct(n[1]);let t;for(t=0;t<ot.length;t+=1){const I=Ot(n,ot,t);x[t]?x[t].p(I,R):(x[t]=Gt(I),x[t].c(),x[t].m(at,null))}for(;t<x.length;t+=1)x[t].d(1);x.length=ot.length}if(R&4){it=ct(n[2]);let t;for(t=0;t<it.length;t+=1){const I=Nt(n,it,t);D[t]?D[t].p(I,R):(D[t]=Yt(I),D[t].c(),D[t].m(st,null))}for(;t<D.length;t+=1)D[t].d(1);D.length=it.length}},i:ht,o:ht,d(n){n&&(d(a),d(u),d(m)),zt(k,n),zt(x,n),zt(D,n)}}}function ne(o,a,c){let{data:u}=a;const{teachers:m,students:l,teacherLoadLevels:i}=u;return o.$$set=A=>{"data"in A&&c(3,u=A.data)},[m,l,i,u]}class ue extends Kt{constructor(a){super(),Jt(this,a,ne,le,qt,{data:3})}}export{ue as component,he as universal};
