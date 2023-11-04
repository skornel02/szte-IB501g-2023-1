import{a as me}from"../chunks/js.cookie.edb2da2a.js";import{z as L}from"../chunks/index.0ec66d4d.js";import{b as Lt}from"../chunks/paths.535d24fc.js";import{s as be,n as et}from"../chunks/scheduler.572f10a3.js";import{S as pe,i as ge,g as c,s as p,m as j,h,j as T,I as N,c as g,f,n as B,k as C,a as U,C as t,D as Te,K as Ee,J as pt,e as ne}from"../chunks/index.21ac587f.js";import{e as F}from"../chunks/each.73a1c622.js";import{i as Ce}from"../chunks/navigation.b5643576.js";const ye=L.object({username:L.string(),name:L.string(),birthDate:L.string(),birthLocation:L.string()}),ke=L.array(ye),De=L.object({username:L.string(),name:L.string(),courseCount:L.number()}),Le=L.array(De),ze=L.object({name:L.string(),username:L.string(),semester:L.string(),hours:L.number()}),Se=L.array(ze),xe=L.object({courseCode:L.string(),courseSemester:L.string()}),Re=L.object({courseCode:L.string(),courseSemester:L.string(),examDate:L.string()}),Ae=L.object({capacity:L.number(),courses:L.array(xe),exams:L.array(Re)}),je=async({fetch:d})=>{const e=me.get("oktato-token");let i=[],_=[],E=[],b;try{const k=await(await d(Lt+"/api/statistics/teachers",{method:"GET",headers:{Authorization:`Bearer ${e}`,"Content-Type":"application/json"}})).json();i=await ke.parseAsync(k)}catch(n){console.error("Teacher statistics failed!",n)}try{const k=await(await d(Lt+"/api/statistics/teacher-load-level",{method:"GET",headers:{Authorization:`Bearer ${e}`,"Content-Type":"application/json"}})).json();_=await Se.parseAsync(k)}catch(n){console.error("Teacher load level statistics failed!",n)}try{const k=await(await d(Lt+"/api/statistics/students",{method:"GET",headers:{Authorization:`Bearer ${e}`,"Content-Type":"application/json"}})).json();E=await Le.parseAsync(k)}catch(n){console.error("Student statistics failed!",n)}try{const k=await(await d(Lt+"/api/statistics/largest-classroom",{method:"GET",headers:{Authorization:`Bearer ${e}`,"Content-Type":"application/json"}})).json();b=await Ae.parseAsync(k)}catch(n){console.error("Biggest classroom statistics failed!",n)}return{teachers:i,students:E,teacherLoadLevels:_,classRoom:b}},Fe=Object.freeze(Object.defineProperty({__proto__:null,load:je},Symbol.toStringTag,{value:"Module"}));function re(d,e,i){const _=d.slice();return _[6]=e[i],_}function oe(d,e,i){const _=d.slice();return _[9]=e[i],_}function ie(d,e,i){const _=d.slice();return _[12]=e[i],_}function ce(d,e,i){const _=d.slice();return _[15]=e[i],_}function he(d,e,i){const _=d.slice();return _[18]=e[i],_}function de(d){let e,i,_=d[18].username+"",E,b,n,k=d[18].name+"",D,s,r,S=d[18].birthDate+"",v,a,u,l=d[18].birthLocation+"",x,R;return{c(){e=c("tr"),i=c("td"),E=j(_),b=p(),n=c("td"),D=j(k),s=p(),r=c("td"),v=j(S),a=p(),u=c("td"),x=j(l),R=p()},l(A){e=h(A,"TR",{});var z=T(e);i=h(z,"TD",{});var O=T(i);E=B(O,_),O.forEach(f),b=g(z),n=h(z,"TD",{});var G=T(n);D=B(G,k),G.forEach(f),s=g(z),r=h(z,"TD",{});var P=T(r);v=B(P,S),P.forEach(f),a=g(z),u=h(z,"TD",{});var Q=T(u);x=B(Q,l),Q.forEach(f),R=g(z),z.forEach(f)},m(A,z){U(A,e,z),t(e,i),t(i,E),t(e,b),t(e,n),t(n,D),t(e,s),t(e,r),t(r,v),t(e,a),t(e,u),t(u,x),t(e,R)},p:et,d(A){A&&f(e)}}}function ue(d){let e,i,_=d[15].username+"",E,b,n,k=d[15].name+"",D,s,r,S=d[15].courseCount+"",v,a;return{c(){e=c("tr"),i=c("td"),E=j(_),b=p(),n=c("td"),D=j(k),s=p(),r=c("td"),v=j(S),a=p()},l(u){e=h(u,"TR",{});var l=T(e);i=h(l,"TD",{});var x=T(i);E=B(x,_),x.forEach(f),b=g(l),n=h(l,"TD",{});var R=T(n);D=B(R,k),R.forEach(f),s=g(l),r=h(l,"TD",{});var A=T(r);v=B(A,S),A.forEach(f),a=g(l),l.forEach(f)},m(u,l){U(u,e,l),t(e,i),t(i,E),t(e,b),t(e,n),t(n,D),t(e,s),t(e,r),t(r,v),t(e,a)},p:et,d(u){u&&f(e)}}}function Be(d){let e,i="<th>Kurzuskód</th> <th>Szemeszter</th> <th>-</th>",_,E,b,n="<th>Kurzuskód</th> <th>Szemeszter</th> <th>Vizsga időpont</th>",k,D,s=F(d[2].courses),r=[];for(let a=0;a<s.length;a+=1)r[a]=fe(ie(d,s,a));let S=F(d[2].exams),v=[];for(let a=0;a<S.length;a+=1)v[a]=_e(oe(d,S,a));return{c(){e=c("tr"),e.innerHTML=i,_=p();for(let a=0;a<r.length;a+=1)r[a].c();E=p(),b=c("tr"),b.innerHTML=n,k=p();for(let a=0;a<v.length;a+=1)v[a].c();D=ne()},l(a){e=h(a,"TR",{"data-svelte-h":!0}),N(e)!=="svelte-1628rpz"&&(e.innerHTML=i),_=g(a);for(let u=0;u<r.length;u+=1)r[u].l(a);E=g(a),b=h(a,"TR",{"data-svelte-h":!0}),N(b)!=="svelte-1sv870l"&&(b.innerHTML=n),k=g(a);for(let u=0;u<v.length;u+=1)v[u].l(a);D=ne()},m(a,u){U(a,e,u),U(a,_,u);for(let l=0;l<r.length;l+=1)r[l]&&r[l].m(a,u);U(a,E,u),U(a,b,u),U(a,k,u);for(let l=0;l<v.length;l+=1)v[l]&&v[l].m(a,u);U(a,D,u)},p(a,u){if(u&4){s=F(a[2].courses);let l;for(l=0;l<s.length;l+=1){const x=ie(a,s,l);r[l]?r[l].p(x,u):(r[l]=fe(x),r[l].c(),r[l].m(E.parentNode,E))}for(;l<r.length;l+=1)r[l].d(1);r.length=s.length}if(u&4){S=F(a[2].exams);let l;for(l=0;l<S.length;l+=1){const x=oe(a,S,l);v[l]?v[l].p(x,u):(v[l]=_e(x),v[l].c(),v[l].m(D.parentNode,D))}for(;l<v.length;l+=1)v[l].d(1);v.length=S.length}},d(a){a&&(f(e),f(_),f(E),f(b),f(k),f(D)),pt(r,a),pt(v,a)}}}function fe(d){let e,i,_=d[12].courseCode+"",E,b,n,k=d[12].courseSemester+"",D;return{c(){e=c("tr"),i=c("td"),E=j(_),b=p(),n=c("td"),D=j(k),this.h()},l(s){e=h(s,"TR",{});var r=T(e);i=h(r,"TD",{});var S=T(i);E=B(S,_),S.forEach(f),b=g(r),n=h(r,"TD",{colspan:!0});var v=T(n);D=B(v,k),v.forEach(f),r.forEach(f),this.h()},h(){C(n,"colspan","2")},m(s,r){U(s,e,r),t(e,i),t(i,E),t(e,b),t(e,n),t(n,D)},p:et,d(s){s&&f(e)}}}function _e(d){let e,i,_=d[9].courseCode+"",E,b,n,k=d[9].courseSemester+"",D,s,r,S=d[9].examDate+"",v,a;return{c(){e=c("tr"),i=c("td"),E=j(_),b=p(),n=c("td"),D=j(k),s=p(),r=c("td"),v=j(S),a=p()},l(u){e=h(u,"TR",{});var l=T(e);i=h(l,"TD",{});var x=T(i);E=B(x,_),x.forEach(f),b=g(l),n=h(l,"TD",{});var R=T(n);D=B(R,k),R.forEach(f),s=g(l),r=h(l,"TD",{});var A=T(r);v=B(A,S),A.forEach(f),a=g(l),l.forEach(f)},m(u,l){U(u,e,l),t(e,i),t(i,E),t(e,b),t(e,n),t(n,D),t(e,s),t(e,r),t(r,v),t(e,a)},p:et,d(u){u&&f(e)}}}function ve(d){let e,i,_=d[6].name+"",E,b,n,k=d[6].username+"",D,s,r,S=d[6].semester+"",v,a,u,l=d[6].hours+"",x,R;return{c(){e=c("tr"),i=c("td"),E=j(_),b=p(),n=c("td"),D=j(k),s=p(),r=c("td"),v=j(S),a=p(),u=c("td"),x=j(l),R=p()},l(A){e=h(A,"TR",{});var z=T(e);i=h(z,"TD",{});var O=T(i);E=B(O,_),O.forEach(f),b=g(z),n=h(z,"TD",{});var G=T(n);D=B(G,k),G.forEach(f),s=g(z),r=h(z,"TD",{});var P=T(r);v=B(P,S),P.forEach(f),a=g(z),u=h(z,"TD",{});var Q=T(u);x=B(Q,l),Q.forEach(f),R=g(z),z.forEach(f)},m(A,z){U(A,e,z),t(e,i),t(i,E),t(e,b),t(e,n),t(n,D),t(e,s),t(e,r),t(r,v),t(e,a),t(e,u),t(u,x),t(e,R)},p:et,d(A){A&&f(e)}}}function we(d){var Zt;let e,i,_="Statisztikák",E,b,n,k="Frissítés",D,s,r,S,v,a="Oktatók",u,l,x,R,A="Hallgatók",z,O,G,P,Q="Legnagyobb terem",zt,lt,St,tt,Gt="Oktató leterheltség",xt,K,at,Kt="Az oktatók kilistázva, fiatalabbtól az idősebbig.",Rt,W,st,Yt="<tr><th>Felhasználó név</th> <th>Név</th> <th>Születési dátum</th> <th>Születési hely</th></tr>",At,nt,jt,Y,rt,$t="Hallgatók által felvett kurzus mennyiség, a hallgatók neve ABC szerinti sorrendben.",Bt,X,ot,qt="<tr><th>Felhasználó név</th> <th>Név</th> <th>Kurzusok száma</th></tr>",wt,it,Ht,$,ct,It,Jt=((Zt=d[2])==null?void 0:Zt.capacity)+"",Mt,Nt,ht,bt,Pt,q,dt,Qt="Tanárok leterheltsége egyes félévekben. Aki nem tart órát, az nem jelenik meg a listában.",Ot,Z,ut,Wt="<tr><th>Felhasználónév</th> <th>Név</th> <th>Félév</th> <th>Órák száma</th></tr>",Ut,ft,Vt,Xt,_t=F(d[0]),w=[];for(let m=0;m<_t.length;m+=1)w[m]=de(he(d,_t,m));let vt=F(d[1]),H=[];for(let m=0;m<vt.length;m+=1)H[m]=ue(ce(d,vt,m));let J=d[2]!==void 0&&Be(d),mt=F(d[3]),I=[];for(let m=0;m<mt.length;m+=1)I[m]=ve(re(d,mt,m));return{c(){e=c("div"),i=c("h1"),i.textContent=_,E=p(),b=c("div"),n=c("button"),n.textContent=k,D=p(),s=c("div"),r=c("input"),S=p(),v=c("label"),v.textContent=a,u=p(),l=c("input"),x=p(),R=c("label"),R.textContent=A,z=p(),O=c("input"),G=p(),P=c("label"),P.textContent=Q,zt=p(),lt=c("input"),St=p(),tt=c("label"),tt.textContent=Gt,xt=p(),K=c("div"),at=c("p"),at.textContent=Kt,Rt=p(),W=c("table"),st=c("thead"),st.innerHTML=Yt,At=p(),nt=c("tbody");for(let m=0;m<w.length;m+=1)w[m].c();jt=p(),Y=c("div"),rt=c("p"),rt.textContent=$t,Bt=p(),X=c("table"),ot=c("thead"),ot.innerHTML=qt,wt=p(),it=c("tbody");for(let m=0;m<H.length;m+=1)H[m].c();Ht=p(),$=c("div"),ct=c("p"),It=j("A legnagyobb (kapacitású) terem összesen "),Mt=j(Jt),Nt=p(),ht=c("table"),bt=c("tbody"),J&&J.c(),Pt=p(),q=c("div"),dt=c("p"),dt.textContent=Qt,Ot=p(),Z=c("table"),ut=c("thead"),ut.innerHTML=Wt,Ut=p(),ft=c("tbody");for(let m=0;m<I.length;m+=1)I[m].c();this.h()},l(m){e=h(m,"DIV",{class:!0});var M=T(e);i=h(M,"H1",{class:!0,"data-svelte-h":!0}),N(i)!=="svelte-5l8x3o"&&(i.textContent=_),E=g(M),b=h(M,"DIV",{class:!0});var o=T(b);n=h(o,"BUTTON",{class:!0,"data-svelte-h":!0}),N(n)!=="svelte-cmd684"&&(n.textContent=k),o.forEach(f),D=g(M),s=h(M,"DIV",{class:!0});var y=T(s);r=h(y,"INPUT",{id:!0,type:!0,name:!0}),S=g(y),v=h(y,"LABEL",{for:!0,"data-svelte-h":!0}),N(v)!=="svelte-1ehvetb"&&(v.textContent=a),u=g(y),l=h(y,"INPUT",{id:!0,type:!0,name:!0}),x=g(y),R=h(y,"LABEL",{for:!0,"data-svelte-h":!0}),N(R)!=="svelte-zs39cg"&&(R.textContent=A),z=g(y),O=h(y,"INPUT",{id:!0,type:!0,name:!0}),G=g(y),P=h(y,"LABEL",{for:!0,"data-svelte-h":!0}),N(P)!=="svelte-1cd6fmh"&&(P.textContent=Q),zt=g(y),lt=h(y,"INPUT",{id:!0,type:!0,name:!0}),St=g(y),tt=h(y,"LABEL",{for:!0,"data-svelte-h":!0}),N(tt)!=="svelte-wpx73x"&&(tt.textContent=Gt),xt=g(y),K=h(y,"DIV",{class:!0,id:!0});var gt=T(K);at=h(gt,"P",{"data-svelte-h":!0}),N(at)!=="svelte-37ekjw"&&(at.textContent=Kt),Rt=g(gt),W=h(gt,"TABLE",{class:!0});var Tt=T(W);st=h(Tt,"THEAD",{"data-svelte-h":!0}),N(st)!=="svelte-1cp0opd"&&(st.innerHTML=Yt),At=g(Tt),nt=h(Tt,"TBODY",{});var te=T(nt);for(let V=0;V<w.length;V+=1)w[V].l(te);te.forEach(f),Tt.forEach(f),gt.forEach(f),jt=g(y),Y=h(y,"DIV",{class:!0,id:!0});var Et=T(Y);rt=h(Et,"P",{"data-svelte-h":!0}),N(rt)!=="svelte-1hw3mrc"&&(rt.textContent=$t),Bt=g(Et),X=h(Et,"TABLE",{class:!0});var Ct=T(X);ot=h(Ct,"THEAD",{"data-svelte-h":!0}),N(ot)!=="svelte-3vxmhf"&&(ot.innerHTML=qt),wt=g(Ct),it=h(Ct,"TBODY",{});var ee=T(it);for(let V=0;V<H.length;V+=1)H[V].l(ee);ee.forEach(f),Ct.forEach(f),Et.forEach(f),Ht=g(y),$=h(y,"DIV",{class:!0,id:!0});var yt=T($);ct=h(yt,"P",{});var Ft=T(ct);It=B(Ft,"A legnagyobb (kapacitású) terem összesen "),Mt=B(Ft,Jt),Ft.forEach(f),Nt=g(yt),ht=h(yt,"TABLE",{class:!0});var le=T(ht);bt=h(le,"TBODY",{});var ae=T(bt);J&&J.l(ae),ae.forEach(f),le.forEach(f),yt.forEach(f),Pt=g(y),q=h(y,"DIV",{class:!0,id:!0});var kt=T(q);dt=h(kt,"P",{"data-svelte-h":!0}),N(dt)!=="svelte-ynm90j"&&(dt.textContent=Qt),Ot=g(kt),Z=h(kt,"TABLE",{class:!0});var Dt=T(Z);ut=h(Dt,"THEAD",{"data-svelte-h":!0}),N(ut)!=="svelte-aazb5"&&(ut.innerHTML=Wt),Ut=g(Dt),ft=h(Dt,"TBODY",{});var se=T(ft);for(let V=0;V<I.length;V+=1)I[V].l(se);se.forEach(f),Dt.forEach(f),kt.forEach(f),y.forEach(f),M.forEach(f),this.h()},h(){C(i,"class","svelte-fztgn1"),C(n,"class","btn-small btn-secondary"),C(b,"class","toolbar svelte-fztgn1"),C(r,"id","tab1"),C(r,"type","radio"),C(r,"name","tabs"),r.checked=!0,C(v,"for","tab1"),C(l,"id","tab2"),C(l,"type","radio"),C(l,"name","tabs"),C(R,"for","tab2"),C(O,"id","tab3"),C(O,"type","radio"),C(O,"name","tabs"),C(P,"for","tab3"),C(lt,"id","tab4"),C(lt,"type","radio"),C(lt,"name","tabs"),C(tt,"for","tab4"),C(W,"class","table-hover"),C(K,"class","content"),C(K,"id","content1"),C(X,"class","table-hover"),C(Y,"class","content"),C(Y,"id","content2"),C(ht,"class","table-hover"),C($,"class","content"),C($,"id","content3"),C(Z,"class","table-hover"),C(q,"class","content"),C(q,"id","content4"),C(s,"class","row flex-spaces tabs"),C(e,"class","container")},m(m,M){U(m,e,M),t(e,i),t(e,E),t(e,b),t(b,n),t(e,D),t(e,s),t(s,r),t(s,S),t(s,v),t(s,u),t(s,l),t(s,x),t(s,R),t(s,z),t(s,O),t(s,G),t(s,P),t(s,zt),t(s,lt),t(s,St),t(s,tt),t(s,xt),t(s,K),t(K,at),t(K,Rt),t(K,W),t(W,st),t(W,At),t(W,nt);for(let o=0;o<w.length;o+=1)w[o]&&w[o].m(nt,null);t(s,jt),t(s,Y),t(Y,rt),t(Y,Bt),t(Y,X),t(X,ot),t(X,wt),t(X,it);for(let o=0;o<H.length;o+=1)H[o]&&H[o].m(it,null);t(s,Ht),t(s,$),t($,ct),t(ct,It),t(ct,Mt),t($,Nt),t($,ht),t(ht,bt),J&&J.m(bt,null),t(s,Pt),t(s,q),t(q,dt),t(q,Ot),t(q,Z),t(Z,ut),t(Z,Ut),t(Z,ft);for(let o=0;o<I.length;o+=1)I[o]&&I[o].m(ft,null);Vt||(Xt=Te(n,"click",Ee(d[4])),Vt=!0)},p(m,[M]){if(M&1){_t=F(m[0]);let o;for(o=0;o<_t.length;o+=1){const y=he(m,_t,o);w[o]?w[o].p(y,M):(w[o]=de(y),w[o].c(),w[o].m(nt,null))}for(;o<w.length;o+=1)w[o].d(1);w.length=_t.length}if(M&2){vt=F(m[1]);let o;for(o=0;o<vt.length;o+=1){const y=ce(m,vt,o);H[o]?H[o].p(y,M):(H[o]=ue(y),H[o].c(),H[o].m(it,null))}for(;o<H.length;o+=1)H[o].d(1);H.length=vt.length}if(m[2]!==void 0&&J.p(m,M),M&8){mt=F(m[3]);let o;for(o=0;o<mt.length;o+=1){const y=re(m,mt,o);I[o]?I[o].p(y,M):(I[o]=ve(y),I[o].c(),I[o].m(ft,null))}for(;o<I.length;o+=1)I[o].d(1);I.length=mt.length}},i:et,o:et,d(m){m&&f(e),pt(w,m),pt(H,m),J&&J.d(),pt(I,m),Vt=!1,Xt()}}}function He(d,e,i){let{data:_}=e;const{teachers:E,students:b,classRoom:n,teacherLoadLevels:k}=_,D=()=>Ce();return d.$$set=s=>{"data"in s&&i(5,_=s.data)},[E,b,n,k,D,_]}class Ge extends pe{constructor(e){super(),ge(this,e,He,we,be,{data:5})}}export{Ge as component,Fe as universal};
