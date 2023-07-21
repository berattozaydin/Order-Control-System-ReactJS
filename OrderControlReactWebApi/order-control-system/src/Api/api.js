import axios from "axios"; 

//const domainAddr = "";// must be empty on publish
 const domainAddr = "localhost:15671"; // NO WRITE http://
 
export const protocolIfNeed = domainAddr ? "http://" : "";
export const domainAddress = domainAddr;
export const baseURL = `${protocolIfNeed}${domainAddr}/api`;
export const storeKey = "tp-yldz-hdgl-user";


const Api = axios.create({
  baseURL,
});

export default Api;