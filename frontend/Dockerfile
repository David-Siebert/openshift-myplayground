FROM node as build
WORKDIR /app
COPY ./DemoUI/package*.json /app/
RUN npm install
COPY . .
RUN npm run build -- --configuration production

FROM nginx as final
COPY --from=build /app/dist/k8s-angular/* /usr/share/nginx/html/