import{a as Ze}from"../chunks/js.cookie.edb2da2a.js";import{b as Ie}from"../chunks/paths.f73f6e8d.js";import{E as $e}from"../chunks/ExamDto.2ccd907e.js";import{C as et}from"../chunks/ClassRoomDto.89c5393b.js";import{e as tt}from"../chunks/index.93323930.js";import{s as st,f as h,a as k,l as O,g as p,h as S,L as F,c as T,m as V,d as v,j as f,F as Pe,i as G,x as n,N as ke,O as Ee,y as X,Q as lt,n as ee,C as ye,M as Me,z as ot,A as rt,o as at,e as He,P as Ue}from"../chunks/scheduler.3ae9c5b3.js";import{e as Te}from"../chunks/each.ed53a14b.js";import{S as nt,i as it}from"../chunks/index.4a313e9c.js";import{a as Re,E as ct}from"../chunks/examtypes.71cfa446.js";import{t as ut}from"../chunks/SvelteToast.svelte_svelte_type_style_lang.eae3c669.js";import{E as ft}from"../chunks/ErrorResponseDto.3330ec0e.js";import{p as dt}from"../chunks/stores.e934c465.js";import{z as $}from"../chunks/index.0ec66d4d.js";const mt=async({fetch:l})=>{const e=Ze.get("oktato-token");let s=[],r=[];try{const t=await(await l(Ie+"/api/exams?teachedByMe=true",{method:"GET",headers:{Authorization:`Bearer ${e}`,"Content-Type":"application/json"}})).json();s=await $e.parseAsync(t)}catch(a){console.error("Exams loading failed!",a)}try{const a=await l(Ie+"/api/classrooms",{method:"GET",headers:{Authorization:`Bearer ${e}`,"Content-Type":"application/json"}});if(console.log(a),a.status===401)throw tt(401,"Hiba történt a session ellenőrzése közben, kérem lépjen be újra!");const t=await a.json();r=await et.parseAsync(t)}catch(a){console.error("Classroom loading failed!",a)}return{classRooms:r,exams:s}},wt=Object.freeze(Object.defineProperty({__proto__:null,load:mt},Symbol.toStringTag,{value:"Module"})),_t=$.object({courseCode:$.string(),courseSemester:$.string(),originalStart:$.string(),end:$.string(),examType:$.nativeEnum(Re),classRoomAddress:$.string(),classRoomNumber:$.string()}).superRefine(({originalStart:l,end:e},s)=>{new Date(l).getTime()>=new Date(e).getTime()&&s.addIssue({code:"custom",path:["end"],message:"A vége nem lehet a kezdete előtt!"})});function Fe(l,e,s){const r=l.slice();return r[20]=e[s],r}function Xe(l,e,s){const r=l.slice();return r[23]=e[s],r}function ht(l){let e,s=ct(Number(l[23]))+"",r;return{c(){e=h("option"),r=O(s),this.h()},l(a){e=p(a,"OPTION",{});var t=S(e);r=V(t,s),t.forEach(v),this.h()},h(){e.__value=Number(l[23]),Ee(e,e.__value)},m(a,t){G(a,e,t),n(e,r)},p:ye,d(a){a&&v(e)}}}function Ke(l){let e=!isNaN(Number(l[23])),s,r=e&&ht(l);return{c(){r&&r.c(),s=He()},l(a){r&&r.l(a),s=He()},m(a,t){r&&r.m(a,t),G(a,s,t)},p(a,t){e&&r.p(a,t)},d(a){a&&v(s),r&&r.d(a)}}}function qe(l){let e,s=l[2].examType._errors[0]+"",r,a,t,m="X",d,u;return{c(){e=h("div"),r=O(s),a=k(),t=h("butto"),t.textContent=m,this.h()},l(o){e=p(o,"DIV",{id:!0,class:!0});var i=S(e);r=V(i,s),a=T(i),t=p(i,"BUTTO",{class:!0,for:!0,"data-svelte-h":!0}),F(t)!=="svelte-16g1nl3"&&(t.textContent=m),i.forEach(v),this.h()},h(){f(t,"class","btn-close"),f(t,"for","login-alert"),f(e,"id","login-alert"),f(e,"class","alert alert-danger dismissible")},m(o,i){G(o,e,i),n(e,r),n(e,a),n(e,t),d||(u=X(t,"click",l[9]),d=!0)},p(o,i){i&4&&s!==(s=o[2].examType._errors[0]+"")&&ee(r,s)},d(o){o&&v(e),d=!1,u()}}}function Ge(l){let e,s=l[20].name+"",r,a,t=l[20].capacity+"",m,d;return{c(){e=h("option"),r=O(s),a=O(" (Kapacitás: "),m=O(t),d=O(`)
					`),this.h()},l(u){e=p(u,"OPTION",{});var o=S(e);r=V(o,s),a=V(o," (Kapacitás: "),m=V(o,t),d=V(o,`)
					`),o.forEach(v),this.h()},h(){e.__value=`${l[20].address}|${l[20].roomNumber}`,Ee(e,e.__value)},m(u,o){G(u,e,o),n(e,r),n(e,a),n(e,m),n(e,d)},p:ye,d(u){u&&v(e)}}}function Je(l){let e,s=l[2].classRoomAddress._errors[0]+"",r,a,t,m="X",d,u;return{c(){e=h("div"),r=O(s),a=k(),t=h("butto"),t.textContent=m,this.h()},l(o){e=p(o,"DIV",{id:!0,class:!0});var i=S(e);r=V(i,s),a=T(i),t=p(i,"BUTTO",{class:!0,for:!0,"data-svelte-h":!0}),F(t)!=="svelte-1aa6wep"&&(t.textContent=m),i.forEach(v),this.h()},h(){f(t,"class","btn-close"),f(t,"for","login-alert"),f(e,"id","login-alert"),f(e,"class","alert alert-danger dismissible")},m(o,i){G(o,e,i),n(e,r),n(e,a),n(e,t),d||(u=X(t,"click",l[11]),d=!0)},p(o,i){i&4&&s!==(s=o[2].classRoomAddress._errors[0]+"")&&ee(r,s)},d(o){o&&v(e),d=!1,u()}}}function Qe(l){let e,s=l[2].classRoomNumber._errors[0]+"",r,a,t,m="X",d,u;return{c(){e=h("div"),r=O(s),a=k(),t=h("butto"),t.textContent=m,this.h()},l(o){e=p(o,"DIV",{id:!0,class:!0});var i=S(e);r=V(i,s),a=T(i),t=p(i,"BUTTO",{class:!0,for:!0,"data-svelte-h":!0}),F(t)!=="svelte-1ot7n94"&&(t.textContent=m),i.forEach(v),this.h()},h(){f(t,"class","btn-close"),f(t,"for","login-alert"),f(e,"id","login-alert"),f(e,"class","alert alert-danger dismissible")},m(o,i){G(o,e,i),n(e,r),n(e,a),n(e,t),d||(u=X(t,"click",l[12]),d=!0)},p(o,i){i&4&&s!==(s=o[2].classRoomNumber._errors[0]+"")&&ee(r,s)},d(o){o&&v(e),d=!1,u()}}}function We(l){let e,s=l[2].end._errors[0]+"",r,a,t,m="X",d,u;return{c(){e=h("div"),r=O(s),a=k(),t=h("butto"),t.textContent=m,this.h()},l(o){e=p(o,"DIV",{id:!0,class:!0});var i=S(e);r=V(i,s),a=T(i),t=p(i,"BUTTO",{class:!0,for:!0,"data-svelte-h":!0}),F(t)!=="svelte-1br8040"&&(t.textContent=m),i.forEach(v),this.h()},h(){f(t,"class","btn-close"),f(t,"for","login-alert"),f(e,"id","login-alert"),f(e,"class","alert alert-danger dismissible")},m(o,i){G(o,e,i),n(e,r),n(e,a),n(e,t),d||(u=X(t,"click",l[14]),d=!0)},p(o,i){i&4&&s!==(s=o[2].end._errors[0]+"")&&ee(r,s)},d(o){o&&v(e),d=!1,u()}}}function Ye(l){let e,s=l[2]._errors[0]+"",r,a,t,m="X",d,u;return{c(){e=h("div"),r=O(s),a=k(),t=h("label"),t.textContent=m,this.h()},l(o){e=p(o,"DIV",{id:!0,class:!0});var i=S(e);r=V(i,s),a=T(i),t=p(i,"LABEL",{class:!0,for:!0,"data-svelte-h":!0}),F(t)!=="svelte-1oxwuyn"&&(t.textContent=m),i.forEach(v),this.h()},h(){f(t,"class","btn-close"),f(t,"for","login-alert"),f(e,"id","login-alert"),f(e,"class","alert alert-danger dismissible")},m(o,i){G(o,e,i),n(e,r),n(e,a),n(e,t),d||(u=X(t,"click",l[15]),d=!0)},p(o,i){i&4&&s!==(s=o[2]._errors[0]+"")&&ee(r,s)},d(o){o&&v(e),d=!1,u()}}}function pt(l){var Ve,je,xe,Le;let e,s,r="Vizsga szerkesztése",a,t,m,d,u=l[1].courseCode+"",o,i,te=l[1].courseSemester+"",re,P,he,J,pe,se=l[1].originalStart+"",ae,ve,L,K,ge="Vizsga típusa",ne,j,ie,ce,E,M,be="Terem",ue,A,C,B,H,x,U,we="Vizsga vége",Se,q,Ae,Ne,Ce,Q,ze='<button type="submit" class="btn-primary">Mentés</button>',De,Oe,fe=Te(Object.keys(Re)),y=[];for(let c=0;c<fe.length;c+=1)y[c]=Ke(Xe(l,fe,c));let N=((Ve=l[2])==null?void 0:Ve.examType)&&qe(l),de=Te(l[3]),R=[];for(let c=0;c<de.length;c+=1)R[c]=Ge(Fe(l,de,c));let D=((je=l[2])==null?void 0:je.classRoomAddress)&&Je(l),I=((xe=l[2])==null?void 0:xe.classRoomNumber)&&Qe(l),w=((Le=l[2])==null?void 0:Le.end)&&We(l),z=l[2]._errors.length>0&&Ye(l);return{c(){e=h("div"),s=h("h3"),s.textContent=r,a=k(),t=h("form"),m=h("div"),d=h("h4"),o=O(u),i=O(" (Félév: "),re=O(te),P=O(")"),he=k(),J=h("p"),pe=O("Kezdet: "),ae=O(se),ve=k(),L=h("div"),K=h("label"),K.textContent=ge,ne=k(),j=h("select");for(let c=0;c<y.length;c+=1)y[c].c();ie=k(),N&&N.c(),ce=k(),E=h("div"),M=h("label"),M.textContent=be,ue=k(),A=h("select");for(let c=0;c<R.length;c+=1)R[c].c();C=k(),D&&D.c(),B=k(),I&&I.c(),H=k(),x=h("div"),U=h("label"),U.textContent=we,Se=k(),q=h("input"),Ae=k(),w&&w.c(),Ne=k(),z&&z.c(),Ce=k(),Q=h("div"),Q.innerHTML=ze,this.h()},l(c){e=p(c,"DIV",{class:!0});var b=S(e);s=p(b,"H3",{class:!0,"data-svelte-h":!0}),F(s)!=="svelte-1ib7sc4"&&(s.textContent=r),a=T(b),t=p(b,"FORM",{method:!0});var g=S(t);m=p(g,"DIV",{class:!0});var le=S(m);d=p(le,"H4",{});var W=S(d);o=V(W,u),i=V(W," (Félév: "),re=V(W,te),P=V(W,")"),W.forEach(v),he=T(le),J=p(le,"P",{});var me=S(J);pe=V(me,"Kezdet: "),ae=V(me,se),me.forEach(v),le.forEach(v),ve=T(g),L=p(g,"DIV",{class:!0});var _=S(L);K=p(_,"LABEL",{for:!0,"data-svelte-h":!0}),F(K)!=="svelte-w6ye21"&&(K.textContent=ge),ne=T(_),j=p(_,"SELECT",{id:!0,class:!0});var Y=S(j);for(let oe=0;oe<y.length;oe+=1)y[oe].l(Y);Y.forEach(v),ie=T(_),N&&N.l(_),_.forEach(v),ce=T(g),E=p(g,"DIV",{class:!0});var Z=S(E);M=p(Z,"LABEL",{for:!0,"data-svelte-h":!0}),F(M)!=="svelte-s9d6ow"&&(M.textContent=be),ue=T(Z),A=p(Z,"SELECT",{id:!0,class:!0});var Be=S(A);for(let oe=0;oe<R.length;oe+=1)R[oe].l(Be);Be.forEach(v),C=T(Z),D&&D.l(Z),B=T(Z),I&&I.l(Z),Z.forEach(v),H=T(g),x=p(g,"DIV",{class:!0});var _e=S(x);U=p(_e,"LABEL",{for:!0,"data-svelte-h":!0}),F(U)!=="svelte-1t7ml1k"&&(U.textContent=we),Se=T(_e),q=p(_e,"INPUT",{type:!0,id:!0,class:!0}),Ae=T(_e),w&&w.l(_e),_e.forEach(v),Ne=T(g),z&&z.l(g),Ce=T(g),Q=p(g,"DIV",{id:!0,class:!0,"data-svelte-h":!0}),F(Q)!=="svelte-1nqhuxy"&&(Q.innerHTML=ze),g.forEach(v),b.forEach(v),this.h()},h(){f(s,"class","svelte-x57mvu"),f(m,"class","form-group text-center"),f(K,"for","courseTypeInput"),f(j,"id","courseTypeInput"),f(j,"class","input-block"),l[1].examType===void 0&&Pe(()=>l[8].call(j)),f(L,"class","form-group"),f(M,"for","classRoomInput"),f(A,"id","classRoomInput"),f(A,"class","input-block"),l[0]===void 0&&Pe(()=>l[10].call(A)),f(E,"class","form-group"),f(U,"for","endDateInput"),f(q,"type","datetime-local"),f(q,"id","endDateInput"),f(q,"class","input-block"),f(x,"class","form-group"),f(Q,"id","form-controls"),f(Q,"class","svelte-x57mvu"),f(t,"method","get"),f(e,"class","container")},m(c,b){G(c,e,b),n(e,s),n(e,a),n(e,t),n(t,m),n(m,d),n(d,o),n(d,i),n(d,re),n(d,P),n(m,he),n(m,J),n(J,pe),n(J,ae),n(t,ve),n(t,L),n(L,K),n(L,ne),n(L,j);for(let g=0;g<y.length;g+=1)y[g]&&y[g].m(j,null);ke(j,l[1].examType,!0),n(L,ie),N&&N.m(L,null),n(t,ce),n(t,E),n(E,M),n(E,ue),n(E,A);for(let g=0;g<R.length;g+=1)R[g]&&R[g].m(A,null);ke(A,l[0],!0),n(E,C),D&&D.m(E,null),n(E,B),I&&I.m(E,null),n(t,H),n(t,x),n(x,U),n(x,Se),n(x,q),Ee(q,l[1].end),n(x,Ae),w&&w.m(x,null),n(t,Ne),z&&z.m(t,null),n(t,Ce),n(t,Q),De||(Oe=[X(j,"change",l[8]),X(A,"change",l[10]),X(A,"change",l[4]),X(q,"input",l[13]),X(t,"submit",lt(l[5]))],De=!0)},p(c,[b]){var g,le,W,me;if(b&2&&u!==(u=c[1].courseCode+"")&&ee(o,u),b&2&&te!==(te=c[1].courseSemester+"")&&ee(re,te),b&2&&se!==(se=c[1].originalStart+"")&&ee(ae,se),b&0){fe=Te(Object.keys(Re));let _;for(_=0;_<fe.length;_+=1){const Y=Xe(c,fe,_);y[_]?y[_].p(Y,b):(y[_]=Ke(Y),y[_].c(),y[_].m(j,null))}for(;_<y.length;_+=1)y[_].d(1);y.length=fe.length}if(b&2&&ke(j,c[1].examType),(g=c[2])!=null&&g.examType?N?N.p(c,b):(N=qe(c),N.c(),N.m(L,null)):N&&(N.d(1),N=null),b&8){de=Te(c[3]);let _;for(_=0;_<de.length;_+=1){const Y=Fe(c,de,_);R[_]?R[_].p(Y,b):(R[_]=Ge(Y),R[_].c(),R[_].m(A,null))}for(;_<R.length;_+=1)R[_].d(1);R.length=de.length}b&9&&ke(A,c[0]),(le=c[2])!=null&&le.classRoomAddress?D?D.p(c,b):(D=Je(c),D.c(),D.m(E,B)):D&&(D.d(1),D=null),(W=c[2])!=null&&W.classRoomNumber?I?I.p(c,b):(I=Qe(c),I.c(),I.m(E,null)):I&&(I.d(1),I=null),b&2&&Ee(q,c[1].end),(me=c[2])!=null&&me.end?w?w.p(c,b):(w=We(c),w.c(),w.m(x,null)):w&&(w.d(1),w=null),c[2]._errors.length>0?z?z.p(c,b):(z=Ye(c),z.c(),z.m(t,Ce)):z&&(z.d(1),z=null)},i:ye,o:ye,d(c){c&&v(e),Me(y,c),N&&N.d(),Me(R,c),D&&D.d(),I&&I.d(),w&&w.d(),z&&z.d(),De=!1,ot(Oe)}}}function vt(l,e,s){var ge,ne,j,ie,ce,E,M,be,ue,A;let r;rt(l,dt,C=>s(17,r=C));let{data:a}=e;const{classRooms:t,exams:m}=a;`${(ge=m[0])==null?void 0:ge.courseCode}${(ne=m[0])==null?void 0:ne.courseSemester}${(j=m[0])==null?void 0:j.start}`;let d=`${(ie=t[0])==null?void 0:ie.address}|${(ce=t[0])==null?void 0:ce.roomNumber}`;const u={courseCode:(E=m[0])==null?void 0:E.courseCode,courseSemester:(M=m[0])==null?void 0:M.courseSemester,originalStart:(be=m[0])==null?void 0:be.start,end:new Date(new Date().getTime()+1e3*3600).toISOString().slice(0,16),examType:Re.Online,classRoomAddress:(ue=t[0])==null?void 0:ue.address,classRoomNumber:(A=t[0])==null?void 0:A.roomNumber};at(()=>{const C=r.url.searchParams.get("exam");if(C){const[B,H,x]=C.split("|");s(1,u.courseCode=B,u),s(1,u.courseSemester=H,u),s(1,u.originalStart=x,u)}});let o={_errors:[]};const i=C=>{const[B,H]=C.target.value.split("|");s(1,u.classRoomAddress=B,u),s(1,u.classRoomNumber=H,u),console.log(u)},te=async C=>{const B=Ze.get("oktato-token"),H=await fetch(Ie+"/api/exams",{method:"PATCH",headers:{Authorization:`Bearer ${B}`,"Content-Type":"application/json"},body:JSON.stringify(C)});if(H.status!==200){const x=await H.json(),U=await ft.safeParseAsync(x);return U.success?U.data.errorMessage:"Ismeretlen hiba történt!"}},re=async()=>{s(2,o={_errors:[]});const C=await _t.safeParseAsync(u);if(C.success){const B=await te(u);B!==void 0?s(2,o._errors=[B],o):ut.push("Vizsga sikeresen létrehozva!")}else s(2,o=C.error.format())},P=C=>{C==="_errors"?s(2,o._errors=[],o):s(2,o[C]=void 0,o)};function he(){u.examType=Ue(this),s(1,u)}const J=()=>P("examType");function pe(){d=Ue(this),s(0,d),s(3,t)}const se=()=>P("classRoomAddress"),ae=()=>P("classRoomNumber");function ve(){u.end=this.value,s(1,u)}const L=()=>P("end"),K=()=>P("_errors");return l.$$set=C=>{"data"in C&&s(7,a=C.data)},[d,u,o,t,i,re,P,a,he,J,pe,se,ae,ve,L,K]}class zt extends nt{constructor(e){super(),it(this,e,vt,pt,st,{data:7})}}export{zt as component,wt as universal};